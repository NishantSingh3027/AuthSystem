using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthSystem.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            ViewBag.Name = Session["Name"] as string;
            ViewBag.Address = Session["Address"] as string;
            return View();
        }
    }
}