using ByJoshgunFinalRestaurantProject.DAL;
using ByJoshgunFinalRestaurantProject.Helpers;
using ByJoshgunFinalRestaurantProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MimeKit;
using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace ByJoshgunFinalRestaurantProject.Controllers
{
    [Authorize(Roles = "SuperAdmin, Admin")]
    public class EmployeesController : Controller
    {
        private readonly AppDbContext _db;
        public EmployeesController(AppDbContext db)  // bu back-den view-a yeni fronta data gondermek ucundur
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            List<Employee> employees = await _db.Employees.Include(x => x.Position).ToListAsync();
            return View(employees);
        }


        #region CreateEmployee Işçi Yarat Metodu

        public async Task<IActionResult> CreateEmployee()
        {
            ViewBag.Positions = await _db.Positions.ToListAsync();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateEmployee(Employee employee, /*int[] positionId,*/ int? posId) // Model Binding Yəni tək tək yazmırıq.
        {
            ViewBag.Positions = await _db.Positions.ToListAsync();
            if (!ModelState.IsValid) // Modelstate yəni modeldə qeyd etdiyimiz required-ləri ödəyirmi deməkdir..
            {
                return View();
            }

            employee.PositionId = (int)posId;
            await _db.Employees.AddAsync(employee);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion


        #region ActivityEmployee Işçini Aktiv Deaktiv Et

        public async Task<IActionResult> ActivityEmployee(int? employeeId)
        {
            if (employeeId == null)
            {
                return NotFound();
            }

            Employee dbEmployee = await _db.Employees.FirstOrDefaultAsync(m => m.Id == employeeId);
            if (dbEmployee == null)
            {
                return BadRequest();
            }
            if (dbEmployee.IsDeactive)
            {
                dbEmployee.IsDeactive = false;
            }
            else
            {
                dbEmployee.IsDeactive = true;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion


        #region UpdateEmployee İşçi Yenilə Metodu

        public async Task<IActionResult> UpdateEmployee(int? employeeId)
        {
            ViewBag.Positions = await _db.Positions.ToListAsync(); // 
            if (employeeId == null)
            {
                return NotFound();
            }

            Employee dbEmployee = await _db.Employees.Include(x => x.Position).FirstOrDefaultAsync(m => m.Id == employeeId);
            if (dbEmployee == null)
            {
                return BadRequest();
            }
            return View(dbEmployee);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateEmployee(int? employeeId, Employee employee, int? posId)
        {
            if (employeeId == null)
            {
                return NotFound();
            }

            Employee dbEmployee = await _db.Employees.Include(x => x.Position).FirstOrDefaultAsync(m => m.Id == employeeId);
            if (dbEmployee == null)
            {
                return BadRequest();
            }
            dbEmployee.Name = employee.Name;
            dbEmployee.Surname = employee.Surname;
            dbEmployee.DateOfBirth = employee.DateOfBirth;
            dbEmployee.PhoneNumber = employee.PhoneNumber;
            dbEmployee.Salary = employee.Salary;
            dbEmployee.IsDeactive = employee.IsDeactive;
            dbEmployee.Email = employee.Email;
            dbEmployee.PositionId = (int)posId;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion


        #region DetailEmployee Işçi Təfərrüatı

        public async Task<IActionResult> DetailEmployee(int? employeeId)
        {
            if (employeeId == null)
            {
                return NotFound();
            }

            Employee dbEmployee = await _db.Employees.Include(x => x.Position).FirstOrDefaultAsync(x => x.Id == employeeId);
            if (dbEmployee == null)
            {
                return BadRequest();
            }

            return View(dbEmployee);
        }

        #endregion



        #region SendMail
        public async Task<IActionResult> SendMail(int? employeeId)
        {
            Employee dbEmployee = await _db.Employees.FirstOrDefaultAsync(x => x.Id == employeeId);
            if (dbEmployee == null)
            {
                return BadRequest();
            }

            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendMail(EmailMessage emailMessage, int? employeeId)
        {
            Employee dbEmployee = await _db.Employees.FirstOrDefaultAsync(x => x.Id == employeeId);
            if (dbEmployee == null)
            {
                return BadRequest();
            }

            emailMessage.To = dbEmployee.Email;


            try
            {

                await Helper.SendMessage(emailMessage.Subject, emailMessage.Body, emailMessage.To);

            }
            catch (Exception exception)
            {


            }

            return RedirectToAction("Index");
        }
        #endregion




    }
}
