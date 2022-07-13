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
    public class MenuController : Controller
    {
        private readonly AppDbContext _db;
        public MenuController(AppDbContext db)  // bu back-den view-a yeni fronta data gondermek ucundur
        {
            _db = db;
        }


        #region Index

        public IActionResult Index()
        {
            List<Menu> Menus = _db.Menus.Include(m => m.Foods).ToList();

            return View(Menus);
        }

        #endregion


        #region CreateKitchen Mətbəx Yarat Metodu

        public IActionResult CreateKitchen()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateKitchen(Menu menu) // Model Binding Yəni tək tək yazmırıq.
        {
            if (!ModelState.IsValid) // Modelstate yəni modeldə qeyd etdiyimiz required-ləri ödəyirimi deməkdir..
            {
                return View();
            }
            bool isExist = await _db.Menus.AnyAsync(m => m.Name == menu.Name);
            if (isExist)
            {   // eyni adda menu yazibsa error qaytarir ki eyni adda olmaz.
                ModelState.AddModelError("Name", "Bu adda mətbəx artıq mövcuddur.");
                return View();
            }

            await _db.Menus.AddAsync(menu); // bu moterizedeki balaca menu istifadəçi tərəfindən yeni qeyd olunan menudur.
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion


        #region UpdateMenuKitchen Mətbəx Yenilə Metodu

        public async Task<IActionResult> UpdateMenuKitchen(int? menuId)
        {
            if (menuId == null)
            {
                return NotFound();
            }

            Menu dbMenu = await _db.Menus.FirstOrDefaultAsync(m => m.Id == menuId);
            if (dbMenu == null)
            {
                return BadRequest();
            }
            return View(dbMenu);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateMenuKitchen(int? menuId, Menu menu)
        {
            if (menuId == null)
            {
                return NotFound();
            }

            Menu dbMenu = await _db.Menus.FirstOrDefaultAsync(m => m.Id == menuId);
            if (dbMenu == null)
            {
                return BadRequest();
            }
            dbMenu.Name = menu.Name;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion


        #region CreateFood Yemək Yarat Metodu

        public IActionResult CreateFood()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateFood(Food food, int menuId) // Model Binding Yəni tək tək yazmırıq.
        {
            if (!ModelState.IsValid) // Modelstate yəni modeldə qeyd etdiyimiz required-ləri ödəyirimi deməkdir..
            {
                return View();
            }

            bool isExist = await _db.Foods.AnyAsync(m => m.Name == food.Name);
            if (isExist)
            {
                ModelState.AddModelError("Name", "Bu adda yemək artıq mövcuddur.");
                return View();
            }
            food.MenuId = menuId;
            await _db.Foods.AddAsync(food);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion


        #region UpdateFood Yemək Yenilə Metodu

        public async Task<IActionResult> UpdateFood(int? foodId)
        {
            if (foodId == null)
            {
                return NotFound();
            }

            Food dbFood = await _db.Foods.FirstOrDefaultAsync(m => m.Id == foodId);
            if (dbFood == null)
            {
                return BadRequest();
            }
            return View(dbFood);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateFood(int? foodId, Food food)
        {
            if (foodId == null)
            {
                return NotFound();
            }

            Food dbFood = await _db.Foods.FirstOrDefaultAsync(m => m.Id == foodId);
            if (dbFood == null)
            {
                return BadRequest();
            }
            dbFood.Name = food.Name;
            dbFood.Ingredient = food.Ingredient;
            dbFood.Price = food.Price;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion


        #region ActivityMenuKitchen Mətbəxi Aktiv Deaktiv Et Metodu

        public async Task<IActionResult> ActivityMenuKitchen(int? menuId)
        {
            if (menuId == null)
            {
                return NotFound();
            }

            Menu dbMenu = await _db.Menus.Include(x => x.Foods).FirstOrDefaultAsync(m => m.Id == menuId);
            if (dbMenu == null)
            {
                return BadRequest();
            }

            if (dbMenu.IsDeactive)
            {
                dbMenu.IsDeactive = false;
                foreach (var item in dbMenu.Foods)
                {
                    item.IsDeactive = false;
                }
            }
            else
            {
                dbMenu.IsDeactive = true;
                foreach (var item in dbMenu.Foods)
                {
                    item.IsDeactive = true;
                }
            }

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion


        #region ActivityFood Yeməyi Aktiv Deaktiv Et Metodu

        public async Task<IActionResult> ActivityFood(int? foodId)
        {
            if (foodId == null)
            {
                return NotFound();
            }

            Food dbFood = await _db.Foods.FirstOrDefaultAsync(m => m.Id == foodId);
            if (dbFood == null)
            {
                return BadRequest();
            }
            if (dbFood.IsDeactive)
            {
                dbFood.IsDeactive = false;
            }
            else
            {
                dbFood.IsDeactive = true;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion


    }
}
