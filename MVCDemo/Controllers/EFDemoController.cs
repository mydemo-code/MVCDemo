using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class EFDemoController : Controller
    {
        MVCDemo.Models.PersonnelManagementSystemEntities db = new Models.PersonnelManagementSystemEntities();
        // GET: EFDemo
        public ActionResult ShowInfo()
        {
           var list =  db.StaffTable.ToList();
            return View(list);
        }

       
        public ActionResult CreatInfo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreatInfo(Models.StaffTable staff)
        {
            db.StaffTable.Add(staff);
            db.SaveChanges();
            return RedirectToAction("ShowInfo");
        }

        public ActionResult UpdateInfo(string id)
        {
            int staffid = Convert.ToInt32(id);
            var obj = db.StaffTable.FirstOrDefault(o => o.StaffNum == staffid);
            return View(obj);
        }

        [HttpPost]
        public ActionResult UpdateInfo(Models.StaffTable obj)
        {

            Models.StaffTable staff = db.StaffTable.FirstOrDefault(o => o.StaffNum == obj.StaffNum);
            UpdateModel(staff);
            db.SaveChanges();
            return RedirectToAction("ShowInfo");
        }


        public ActionResult DeleteInfo(int id)
        {
            Models.StaffTable staff = db.StaffTable.FirstOrDefault(o => o.StaffNum == id);
            db.StaffTable.Remove(staff);
            db.SaveChanges();
            return RedirectToAction("ShowInfo");
        }
        



    }
}