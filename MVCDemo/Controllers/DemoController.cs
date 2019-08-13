using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult index()
        {
            return View();
        }

        //逐一获取传来的值
        public ActionResult GetAction(string Name,string Age)
        { 
            ViewBag.Name = Name;
            ViewBag.Age = Age;
            return View();
        }

        //逐一获取传来的值
        public ActionResult GetActionByForm(string Name, string Age, string Sex, string Tel)
        {
            //使用viewbag存值
            ViewBag.Name1 = Name;
            ViewBag.Age1 = Age;
            ViewBag.Sex1 = Sex;
            ViewBag.Tel1 = Tel;
            
            return View("GetAction");
        }

        //通过对象获取传来的值
        public ActionResult GetActionByObject(Models.Person p)
        {
            ViewData.Model = p;
            ViewBag.peson = p;
            return View(p);
        }

        //通过Ajax请求返回json
        public ActionResult GetActionByAjax(string Name, string Age, string Sex, string Tel)
        {

            var json = new
            {
                Name = Name,
                Age = Age,
                Sex = Sex,
                Tel = Tel
            };
            return Json(json);
        }

        //通过ajax+form获取传来的值
        public ActionResult GetActionByAjaxForm(Models.Person p)
        {
            return Json(p);
        }




    }
}