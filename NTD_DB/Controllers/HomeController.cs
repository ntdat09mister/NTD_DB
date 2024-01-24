using NTD_DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTD_DB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new DbContextStudent())
            {
                var studentList = context.students.ToList();
                foreach (var student in studentList) { System.Diagnostics.Debug.WriteLine($"Student ID: {student.id}, Name: {student.name}"); }
                return View(studentList);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}