using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class EFbyAjaxController : Controller
    {
        PersonnelManagementSystemEntitiesbyLogin db = new PersonnelManagementSystemEntitiesbyLogin();
        // GET: EFbyAjax
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowInfo(string strwhere)
        {
           Func<Models.LoginTable,bool> func = (f) => string.IsNullOrEmpty(strwhere) == true ? true : f.LoginName.Contains(strwhere) ;
           List<LoginTable> list = db.LoginTable.Where(func).ToList();
           return Json(list,JsonRequestBehavior.AllowGet);
        }

        public ActionResult DeleteById(int id)
        {
            LoginTable obj = db.LoginTable.FirstOrDefault(o => o.LoginId == id);
            db.LoginTable.Remove(obj);
            db.SaveChanges();
            return Content("true");
        }

        
        public ActionResult UpdateById(int id)
        {
            LoginTable obj = db.LoginTable.FirstOrDefault(o => o.LoginId == id);
            return View(obj);
        }

        [HttpPost]
        public ActionResult UpdateById(LoginTable login)
        {
            login = db.LoginTable.FirstOrDefault(o => o.LoginId == login.LoginId);
            UpdateModel(login);
            db.SaveChanges();
            return Content("true");
        }

        public ActionResult AddInfo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddInfo(LoginTable login)
        {
            db.LoginTable.Add(login);
            int i =  db.SaveChanges();
            return i > 0 ? Content("true") : Content("false");
        }






    }
}