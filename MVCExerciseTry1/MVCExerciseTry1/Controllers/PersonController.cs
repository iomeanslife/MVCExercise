using MVCExerciseTry1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExerciseTry1.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            Character model = new Character()
            {
                FirstName = "Omar",
                SurName = "Ajerray",
                Birthyear = DateTime.Parse("1985-06-02")
            };

            return View(model);
        }

        public string Welcome()
        {
            return "This is the Welcome action method...";
        } 
    }
}