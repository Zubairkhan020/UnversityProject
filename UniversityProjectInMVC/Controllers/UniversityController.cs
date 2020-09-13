using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityProjectInMVC.Models;

namespace UniversityProjectInMVC.Controllers
{
    public class UniversityController : Controller
    {

        public Contxt db = new Contxt();

        public ActionResult Index(string search)
        {
            if (search != null)
            {
               return View(db.faculties.Where(x => x.Name.Contains(search)).ToList());
            }

           return View(db.faculties.ToList());
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Faculty f)
        {
            db.faculties.Add(f);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}