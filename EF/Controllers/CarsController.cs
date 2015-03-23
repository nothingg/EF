using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using EF.Models;


namespace EF.Controllers
{
    public class CarsController : Controller
    {
        private AllContext db = new AllContext();

        public ActionResult Lists()
        {
            List<Car> result = CarRespository.GetCar();
            return View("Lists",result);
        }



        //
        // GET: /Cars/

        public ActionResult Index()
        {
            return View();
        }

    }
}
