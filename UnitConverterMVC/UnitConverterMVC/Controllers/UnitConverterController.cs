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
        
    }
}