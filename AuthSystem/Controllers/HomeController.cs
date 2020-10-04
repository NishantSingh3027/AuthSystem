
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AuthSystem.Business;
using AuthSystem.ViewModels;

namespace AuthSystem.Controllers
{
    public class HomeController : Controller
    {
        AuthenticationBL authBusiness = new AuthenticationBL();

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]        
        [ValidateAntiForgeryToken]
        public ActionResult Login(EmployeeModel emp)
        {
            if (ModelState.IsValid)
            {
                bool IsUserAuthenticated = authBusiness.AuthenticateUser(
                    new Models.Employee
                    {
                        Password = emp.Password,
                        UserName = emp.UserName
                    }
                    );
                if (IsUserAuthenticated)
                {
                    Session["Name"] = "Tim Ryan";
                    Session["Address"] = "London,UK";
                    FormsAuthentication.SetAuthCookie(emp.UserName, false);
                    return RedirectToAction("Index", "Employee");
                }
                ViewBag.ErrorMessage = "Provided username or password is invalid";
            }

            return View();
        }

        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Login", "Home");
        }
    }
}