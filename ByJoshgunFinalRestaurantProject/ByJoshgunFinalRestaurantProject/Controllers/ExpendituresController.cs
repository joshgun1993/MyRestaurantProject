using ByJoshgunFinalRestaurantProject.DAL;
using ByJoshgunFinalRestaurantProject.Models;
using ByJoshgunFinalRestaurantProject.ViewModels;
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
    public class ExpendituresController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        public ExpendituresController(AppDbContext db, UserManager<AppUser> userManager)  // bu back-den view-a yeni fronta data gondermek ucundur
        {
            _db = db;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {

            List<Expenditure> expenditureList = await _db.Expenditures.Include(x => x.AppUser).ToListAsync();
            return View(expenditureList);
        }


        #region CreateExpenditure Xerc Yarat Metodu

        public IActionResult CreateExpenditure()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateExpenditure(Expenditure expenditure) // Model Binding Yəni tək tək yazmırıq.
        {
            if (!ModelState.IsValid) // Modelstate yəni modeldə qeyd etdiyimiz required-ləri ödəyirimi deməkdir..
            {
                return View();
            }


            AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);
            expenditure.AppUserId = appUser.Id;
            expenditure.ExpenditureTime = DateTime.UtcNow.AddHours(4);

            await _db.Expenditures.AddAsync(expenditure); // bu moterizedeki balaca menu istifadəçi tərəfindən yeni qeyd olunan menudur.
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion



        public async Task<IActionResult> UpdateExpenditure(int? expenditureId)
        {
            if (expenditureId == null)
            {
                return NotFound();
            }

            {
                Expenditure dbExpenditure = await _db.Expenditures.FirstOrDefaultAsync(x => x.Id == expenditureId);
                if (dbExpenditure == null)
                {
                    return BadRequest();
                }
                return View(dbExpenditure);
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateExpenditure(int? expenditureId, Expenditure expenditure)
        {
            if (expenditureId == null)
            {
                return NotFound();
            }

            {
                Expenditure dbExpenditure = await _db.Expenditures.FirstOrDefaultAsync(x => x.Id == expenditureId);
                if (dbExpenditure == null)
                {
                    return BadRequest();
                }
                dbExpenditure.Price = expenditure.Price;
                dbExpenditure.AboutPrice = expenditure.AboutPrice;
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }





        public async Task<IActionResult> DetailExpenditure(int? expenditureId)
        {
            if (expenditureId == null)
            {
                return NotFound();
            }
            Expenditure dbExpenditure = await _db.Expenditures.FirstOrDefaultAsync(x => x.Id == expenditureId);
            if (dbExpenditure == null)
            {
                return BadRequest();
            }
            return View(dbExpenditure);
        }
    }
}
