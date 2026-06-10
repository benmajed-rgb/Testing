using DentalBusinessCenter.Services;
using Microsoft.AspNetCore.Mvc;

namespace DentalBusinessCenter.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("UserRole")))
                return RedirectToAction("Index", "Dashboard");
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = DataStore.ValidateUser(username, password);
            if (user == null)
            {
                ViewBag.Error = "Invalid username or password.";
                return View();
            }
            HttpContext.Session.SetString("UserId", user.Id.ToString());
            HttpContext.Session.SetString("UserRole", user.Role);
            HttpContext.Session.SetString("UserFullName", user.FullName);
            HttpContext.Session.SetString("DoctorId", user.DoctorId?.ToString() ?? "");
            return RedirectToAction("Index", "Dashboard");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
