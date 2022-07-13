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
    public class PositionsController : Controller
    {
        private readonly AppDbContext _db;
        public PositionsController(AppDbContext db)  // bu back-den view-a yeni fronta data gondermek ucundur
        {
            _db = db;
        }

        #region Index

        public IActionResult Index()
        {
            List<Position> positions = _db.Positions.ToList();
            return View(positions);
        }

        #endregion


        #region CreatePosition Vəzifə Yarat

        public IActionResult CreatePosition()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePosition(Position position) // Model Binding Yəni tək tək yazmırıq.
        {
            if (!ModelState.IsValid) // Modelstate yəni modeldə qeyd etdiyimiz required-ləri ödəyirimi deməkdir..
            {
                return View();
            }

            bool isExist = await _db.Positions.AnyAsync(m => m.PositionName == position.PositionName);
            if (isExist)
            {
                ModelState.AddModelError("PositionName", "Bu adda vəzifə artıq mövcuddur.");
                return View();
            }
            if (position.PositionName == null)
            {
                ModelState.AddModelError("PositionName", "Zəhmət olmazsa ad daxil edin.");
                return View();
            }

            await _db.Positions.AddAsync(position);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion


        #region UpdatePosition Vəzifə Yenile 

        public async Task<IActionResult> UpdatePosition(int? positionId)
        {
            if (positionId == null)
            {
                return NotFound();
            }

            Position dbPosition = await _db.Positions.FirstOrDefaultAsync(m => m.Id == positionId);
            if (dbPosition == null)
            {
                return BadRequest();
            }
            return View(dbPosition);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdatePosition(int? positionId, Position position)
        {
            if (positionId == null)
            {
                return NotFound();
            }

            Position dbPosition = await _db.Positions.FirstOrDefaultAsync(m => m.Id == positionId);
            if (dbPosition == null)
            {
                return BadRequest();
            }
            dbPosition.PositionName = position.PositionName;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion


        #region ActivityPosition Vezifeni Aktiv Deaktiv Et

        public async Task<IActionResult> ActivityPosition(int? activityPositionId)
        {
            if (activityPositionId == null)
            {
                return NotFound();
            }

            Position dbPosition = await _db.Positions.FirstOrDefaultAsync(m => m.Id == activityPositionId);
            if (dbPosition == null)
            {
                return BadRequest();
            }
            if (dbPosition.IsDeactive)
            {
                dbPosition.IsDeactive = false;
            }
            else
            {
                dbPosition.IsDeactive = true;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion
    }
}
