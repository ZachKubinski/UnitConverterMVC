using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UnitConverterMVC.Controllers
{
    public class UnitConverterController : Controller
    {
        public ActionResult Index()
        {
            return View(viewName: "Index", model: 0);
        }

        public ActionResult ZachsConversion()
        {
            return View(viewName: "ZachsConversion", model: 0);
        }

        public ActionResult KevinsConversion()
        {
            return View(viewName: "KevinsConversion", model: 0);
        }

        public ActionResult EmilysConversion()
        {
            return View(viewName: "EmilysConversion", model: 0);
        }

        public ActionResult ThomasConversion()
        {
            return View(viewName: "ThomasConversion", model: 0);
        }

        public ActionResult BillysConversion()
        {
            return View(viewName: "BillysConversion", model: 0);
        }

    }
}