using Assignment_EpiServer.Models;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Assignment_EpiServer.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            var filePath = System.Web.HttpContext.Current.Server.MapPath("~/JsonCache/latest_news.json");
            var result = GetJsonFromCache(filePath);
            var data = this.DecodeJson(result);
            var apiData = new ApiData()
            {
                Data = data
            };
            return View(apiData);
        }
        public dynamic DecodeJson(string json)
        {
            var js = new JavaScriptSerializer();
            var obj = js.Deserialize<dynamic>(json);
            return obj;
        }
        public string GetJsonFromCache(string filePath)
        {
            return System.IO.File.ReadAllText(filePath);
        }
    }
}