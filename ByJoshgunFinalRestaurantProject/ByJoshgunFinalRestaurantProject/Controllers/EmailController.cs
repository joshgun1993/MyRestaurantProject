using ByJoshgunFinalRestaurantProject.Helpers;
using ByJoshgunFinalRestaurantProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ByJoshgunFinalRestaurantProject.Controllers
{
    [Authorize(Roles = "SuperAdmin, Admin")]
    public class EmailController : Controller
    {

        #region Index

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Index(EmailMessage emailMessage)
        {
            string msg = "Email Göndərilmədi";
            try
            {

                await Helper.SendMessage(emailMessage.Subject, emailMessage.Body, emailMessage.To);
                msg = "Mesaj Göndərildi";
            }
            catch (Exception exception)
            {

                msg = exception.Message;
            }
            ViewBag.Msg = msg;
            return RedirectToAction("Index");
        }

        #endregion




    }
}
