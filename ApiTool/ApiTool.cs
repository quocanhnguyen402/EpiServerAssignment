using System.IO;
using System.Web;
using System.Web.Script.Serialization;
using RestSharp;

namespace Assignment_EpiServer.ApiTool
{
    public class ApiTool
    {
        // Base Url of API
        public string BaseUrl = "https://api.covid19api.com/";
        // Get response from the base url and its options using RestSharp
        public dynamic GetApiResult(string extensionName)
        {
            string result = null;
            var extensionNameFile = extensionName.Replace("/", "-");
            // Check if extensionName.json exist 
            var filePath = HttpContext.Current.Server.MapPath
                    ("~/JsonCache/" + extensionNameFile + ".json");
            // If not call the api
            if (!File.Exists(filePath))
            {
                result = GetApiResponse(extensionName);
                // Write the result to cache file
                using (StreamWriter sw = File.AppendText(filePath))
                { 
                    sw.WriteLine(result);
                }
            }
            else
            {
                result = GetJsonFromCache(extensionName,filePath);
            }
            return DecodeJson(result);
        }
        //
        public dynamic GetApiResponse(string extensionName)
        {
            var client = new RestClient(BaseUrl + extensionName);
            var request = new RestRequest("", DataFormat.Json);
            return client.Get(request).Content;
        }
        // Decode JSON to array
        public dynamic DecodeJson(string json)
        {
            var js = new JavaScriptSerializer();
            var obj = js.Deserialize<dynamic>(json);
            return obj;
        }
        // Get Json text from file (cause we cant call the api too much)
        public string GetJsonFromCache(string extensionName,string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}