using EZApartment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EZApartment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ApartmentEntities aptDB = new ApartmentEntities();

            ViewBag.aptusernames = new SelectList(aptDB.Apt_User, "ID", "User_Name");
            ViewBag.apttasknames = new SelectList(aptDB.Apt_Task, "ID", "Task_Name");

            List < Work > works = aptDB.Works.ToList();
            return View(works);
        }

        public JsonResult PostWork(AptWorkVM WorkJson)
        {
            ApartmentEntities aptDB = new ApartmentEntities();
            Apt_Work work = new Apt_Work();
            work.User_ID = WorkJson.Userid;
            work.Task_ID = WorkJson.TaskId;
            work.Work_Date = DateTime.Now;
            aptDB.Apt_Work.Add(work);
            aptDB.SaveChanges();
            return Json("success");
        }

    }
}