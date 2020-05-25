using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_EpiServer.Models
{
    public class ApiData
    {
        public ApiData(string extension)
        {
            var apiTool = new ApiTool.ApiTool();
            this.Data = apiTool.GetApiResult(extension);
        }
        public ApiData()
        {

        }
        public dynamic Data { get; set; }
    }
}