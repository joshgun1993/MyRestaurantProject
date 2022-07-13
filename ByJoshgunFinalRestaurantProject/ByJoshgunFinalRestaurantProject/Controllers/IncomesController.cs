using ByJoshgunFinalRestaurantProject.DAL;
using ByJoshgunFinalRestaurantProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByJoshgunFinalRestaurantProject.Controllers
{
    [Authorize(Roles = "SuperAdmin, Admin")]
    public class IncomesController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        public IncomesController(AppDbContext db, UserManager<AppUser> userManager)  // bu back-den view-a yeni fronta data gondermek ucundur
        {
            _db = db;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {

            List<Income> incomes = await _db.Incomes.Include(x => x.AppUser).ToListAsync();
            return View(incomes);
        }

        #region CreateExpenditure Xerc Yarat Metodu

        public IActionResult CreateIncome()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateIncome(Income income) // Model Binding Yəni tək tək yazmırıq.
        {
            if (!ModelState.IsValid) // Modelstate yəni modeldə qeyd etdiyimiz required-ləri ödəyirimi deməkdir..
            {
                return View();
            }

            AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);
            income.AppUserId = appUser.Id;
            income.IncomesTime = DateTime.UtcNow.AddHours(4);
            await _db.Incomes.AddAsync(income); // bu moterizedeki balaca menu istifadəçi tərəfindən yeni qeyd olunan menudur.
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion



        public async Task<IActionResult> UpdateIncome(int? incomeId)
        {
            if (incomeId == null)
            {
                return NotFound();
            }

            {
                Income dbIncome = await _db.Incomes.FirstOrDefaultAsync(x => x.Id == incomeId);
                if (dbIncome == null)
                {
                    return BadRequest();
                }
                return View(dbIncome);
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateIncome(int? incomeId, Income income)
        {
            if (incomeId == null)
            {
                return NotFound();
            }

            {
                Income dbIncome = await _db.Incomes.FirstOrDefaultAsync(x => x.Id == incomeId);
                if (dbIncome == null)
                {
                    return BadRequest();
                }
                dbIncome.Price = income.Price;
                dbIncome.AboutPrice = income.AboutPrice;
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }





        public async Task<IActionResult> DetailIncome(int? incomeId)
        {
            if (incomeId == null)
            {
                return NotFound();
            }
            Income dbIncome = await _db.Incomes.FirstOrDefaultAsync(x => x.Id == incomeId);
            if (dbIncome == null)
            {
                return BadRequest();
            }
            return View(dbIncome);
        }

    }
}
