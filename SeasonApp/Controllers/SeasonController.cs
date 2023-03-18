using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeasonApp.Controllers
{
    public class SeasonController : Controller
    {
        // GET: /Season/Index
        public ActionResult Index()
        {
            return View();
        }

        //GET: /Season/Show
        // Acquire info about season and send to show.cshtml
        public ActionResult Show(int? temperature)
        {
            //Output string indicating temperature
            if (temperature == null)
            {
                ViewBag.Temp = "unknown";
            }
            else
            {
                ViewBag.Temp = temperature.ToString();
            }

            //Output string message indicating season
            SeasonAPIController controller = new SeasonAPIController();
            ViewBag.Season = controller.GetSeason(temperature);

            return View();
        }
    }
}