using ByJoshgunFinalRestaurantProject.DAL;
using ByJoshgunFinalRestaurantProject.Models;
using ByJoshgunFinalRestaurantProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ByJoshgunFinalRestaurantProject.Controllers
{
    [Authorize(Roles = "SuperAdmin, Admin")]
    public class DashboardController : Controller
    {
        private readonly AppDbContext _db;
        public DashboardController(AppDbContext db)  // bu back-den view-a yeni fronta data gondermek ucundur
        {
            _db = db;
        }


        #region Index

        public IActionResult Index()
        {
            DashboardVM dashboardVM = new()
            {
                Incomes = _db.Incomes.ToList(),
                Expenditures = _db.Expenditures.ToList(),
                Menus = _db.Menus.Include(m => m.Foods).ToList(),
                //MenuWater = _db.MenuWaters.Include(m => m.Water).ToList(),

                //ViewBag.MenuCount = _db.Menus.Count()
            };
            return View(dashboardVM);
        }

        //public IActionResult LoadMore(int skip)
        //{
        //    if (_db.Menus.Count() < skip)
        //    {
        //        return Content("Get the f*ck out of here nigga ;)");
        //    }
        //    List<Menu> Menus = _db.Menus.OrderByDescending(x => x.Id).Skip(skip).Take(2).Include(m => m.Foods).ToList();
        //    return PartialView("_MenusPartial", Menus);
        //}

        #endregion



    }
}
