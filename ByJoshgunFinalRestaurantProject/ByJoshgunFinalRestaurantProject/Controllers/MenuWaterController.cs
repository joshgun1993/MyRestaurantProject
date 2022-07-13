using ByJoshgunFinalRestaurantProject.DAL;
using ByJoshgunFinalRestaurantProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByJoshgunFinalRestaurantProject.Controllers
{
    [Authorize(Roles = "SuperAdmin, Admin")]
    public class MenuWaterController : Controller
    {
        private readonly AppDbContext _db;
        public MenuWaterController(AppDbContext db)  // bu back-den view-a yeni fronta data gondermek ucundur
        {
            _db = db;
        }

        #region Index

        public IActionResult Index()
        {
            List<MenuWater> menuWater = _db.MenuWaters.Include(m => m.Water).ToList();
            return View(menuWater);
        }

        #endregion


        #region CreateMenuWater Menu Su Yarat Metodu

        public IActionResult CreateMenuWater()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateMenuWater(MenuWater menuWater) // Model Binding Yəni tək tək yazmırıq.
        {
            if (!ModelState.IsValid) // Modelstate yəni modeldə qeyd etdiyimiz required-ləri ödəyirimi deməkdir..
            {
                return View();
            }
            bool isExist = await _db.MenuWaters.AnyAsync(m => m.Name == menuWater.Name);
            if (isExist)
            {   // eyni adda menu yazibsa error qaytarir ki eyni adda olmaz.
                ModelState.AddModelError("Name", "Bu adda mətbəx artıq mövcuddur.");
                return View();
            }

            await _db.MenuWaters.AddAsync(menuWater); // bu moterizedeki balaca menu istifadəçi tərəfindən yeni qeyd olunan menudur.
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion


        #region UpdateMenuWater Menu Su Yenilə Metodu

        public async Task<IActionResult> UpdateMenuWater(int? menuWaterId)
        {
            if (menuWaterId == null)
            {
                return NotFound();
            }

            MenuWater dbMenuWater = await _db.MenuWaters.FirstOrDefaultAsync(m => m.Id == menuWaterId);
            if (dbMenuWater == null)
            {
                return BadRequest();
            }
            return View(dbMenuWater);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateMenuWater(int? menuWaterId, MenuWater menuWater)
        {
            if (menuWaterId == null)
            {
                return NotFound();
            }

            MenuWater dbMenuWater = await _db.MenuWaters.FirstOrDefaultAsync(m => m.Id == menuWaterId);
            if (dbMenuWater == null)
            {
                return BadRequest();
            }
            dbMenuWater.Name = menuWater.Name;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion


        #region CreateWater İçki Yarat Metodu

        public IActionResult CreateWater()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateWater(Water water, int menuWaterId) // Model Binding Yəni tək tək yazmırıq.
        {
            if (!ModelState.IsValid) // Modelstate yəni modeldə qeyd etdiyimiz required-ləri ödəyirimi deməkdir..
            {
                return View();
            }

            bool isExist = await _db.Waters.AnyAsync(m => m.Name == water.Name);
            if (isExist)
            {
                ModelState.AddModelError("Name", "Bu adda içki artıq mövcuddur.");
                return View();
            }
            water.MenuWaterId = menuWaterId;
            await _db.Waters.AddAsync(water);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion


        #region UpdateWater İçki Yenilə Metodu

        public async Task<IActionResult> UpdateWater(int? waterId)
        {
            if (waterId == null)
            {
                return NotFound();
            }

            Water dbWater = await _db.Waters.FirstOrDefaultAsync(m => m.Id == waterId);
            if (dbWater == null)
            {
                return BadRequest();
            }
            return View(dbWater);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateWater(int? waterId, Water water)
        {
            if (waterId == null)
            {
                return NotFound();
            }

            Water dbWater = await _db.Waters.FirstOrDefaultAsync(m => m.Id == waterId);
            if (dbWater == null)
            {
                return BadRequest();
            }
            dbWater.Name = water.Name;
            dbWater.Price = water.Price;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion


        #region ActivityMenuKitchen Mətbəxi Aktiv Deaktiv Et Metodu

        public async Task<IActionResult> ActivityMenuWater(int? menuWaterId)
        {
            if (menuWaterId == null)
            {
                return NotFound();
            }

            MenuWater dbMenuWater = await _db.MenuWaters.Include(x => x.Water).FirstOrDefaultAsync(m => m.Id == menuWaterId);
            if (dbMenuWater == null)
            {
                return BadRequest();
            }

            if (dbMenuWater.IsDeactive)
            {
                dbMenuWater.IsDeactive = false;
                foreach (var item in dbMenuWater.Water)
                {
                    item.IsDeactive = false;
                }
            }
            else
            {
                dbMenuWater.IsDeactive = true;
                foreach (var item in dbMenuWater.Water)
                {
                    item.IsDeactive = true;
                }
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion


        #region ActivityWater İçkini Aktiv Deaktiv Et Metodu

        public async Task<IActionResult> ActivityWater(int? waterId)
        {
            if (waterId == null)
            {
                return NotFound();
            }

            Water dbWater = await _db.Waters.FirstOrDefaultAsync(m => m.Id == waterId);
            if (dbWater == null)
            {
                return BadRequest();
            }
            if (dbWater.IsDeactive)
            {
                dbWater.IsDeactive = false;
            }
            else
            {
                dbWater.IsDeactive = true;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion
    }
}
