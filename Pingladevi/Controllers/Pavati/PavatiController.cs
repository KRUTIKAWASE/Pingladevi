using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pingladevi.Models;


namespace Pingladevi.Controllers.Pavati
{
    public class PavatiController : Controller
    {
        //GET:Pavati
        public ActionResult Index()
        {
            return View();
        }
        //public ActionResult PavatiList()
        //{
        //        var model = new PavatiModel().GetPavatiList();
        //        return View("..//Pavati//PavatiList", model);            
        //}
        public ActionResult SavePavati(PavatiModel model)
        {
            try
            {
                return Json(new { message = (new PavatiModel().SavePavati(model)) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception Ex)
            {
                return Json(new { model = Ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
        //public ActionResult GetPavatiList()
        //{
        //    try
        //    {
        //         return Json(new { model = new PavatiModel().GetPavatiList() }, JsonRequestBehavior.AllowGet);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new { ex.Message }, JsonRequestBehavior.AllowGet);
        //    }
        //}

        public ActionResult GetDetailData(int Id)
        {
            try
            {
                return Json(new { model = (new PavatiModel().DetailData(Id)) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception Ex)
            {
                return Json(new { Ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}




