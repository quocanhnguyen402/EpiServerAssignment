using System.Web.Mvc;
using System.Web.Services;
using Assignment_EpiServer.Models;

namespace Assignment_EpiServer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Set title
            ViewBag.Title = "Home Page";
            // Get data from api
            var apiData = new ApiData("summary");
            // Show homepage view
            return View(apiData);
        }

        public ActionResult DataTable()
        {
            // Set title
            ViewBag.Title = "Summary";
            // Get data from api
            var apiData = new ApiData("summary");
            // Show homepage view
            return View(apiData);
        }

        public ActionResult Country()
        {
            // Set title
            ViewBag.Title = "Country";
            ViewBag.CountryCode = RouteData.Values["country_code"];
            // Get slug from url
            var slug = RouteData.Values["country_slug"];
            if ((string)slug == "")
            {
                return Index();
            }
            // Get data from api
            var apiData = new ApiData("total/country/"+slug);
            // Show homepage view
            return View(apiData);
        }
    }
}
