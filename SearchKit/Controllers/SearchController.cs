// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) 2018 Anton Hirov

using System.Web.Mvc;
using Newtonsoft.Json;
using SearchKit.Entities.Seed;

namespace SearchKit.Controllers
{
    public class SearchController : Controller
    {
        // GET: /Search
        public ActionResult Index()
        {
            return View();
        }

        //
        // POST: /Search/GetData
        public ActionResult GetData()
        {
            var initializer = new DataInitializer();
            var data = initializer.Init();

            return Json(new
            {
                data = JsonConvert.SerializeObject(data, GetJsonSettings())
            });
        }

        private static JsonSerializerSettings GetJsonSettings()
        {
            return new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize
            };
        }
    }
}