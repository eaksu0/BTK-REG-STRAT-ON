using System.Security.Cryptography.X509Certificates;
using BTKAKADEMI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BTKAKADEMI.Controllers
{
    public class CourseController:Controller
    {
        public ActionResult Index()
        {
            var model =Repository.Applications;
            return View(model);
        }
        public ActionResult Apply()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Apply([FromForm]Candidate model)
        {
            if (Repository.Applications.Any(c=>c.Email.Equals(model.Email)))
            {
                ModelState.AddModelError("", "There is already an apllication.");
            }
            if (ModelState.IsValid)
            {
                Repository.Add(model);
                return View("Feedback",model);
            }
            return View();

        }
    }

}