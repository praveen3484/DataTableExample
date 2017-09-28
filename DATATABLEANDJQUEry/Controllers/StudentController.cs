using DATATABLEANDJQUEry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DATATABLEANDJQUEry.Controllers
{
    public class StudentController : Controller
    {
        private Context db = new Context();
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
    }
}