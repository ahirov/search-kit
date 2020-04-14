// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) Anton Hirov

using System.Web.Mvc;
using Newtonsoft.Json;
using SearchKit.Converters;
using SearchKit.Service;

namespace SearchKit.Controllers
{
    public class SearchController : Controller
    {
        private readonly ISectionLoader sectionLoader;
        private readonly ISectionModelConverter sectionConverter;

        public SearchController(ISectionLoader sectionLoader,
                                ISectionModelConverter sectionConverter)
        {
            this.sectionLoader = sectionLoader;
            this.sectionConverter = sectionConverter;
        }

        // GET: /Search
        public ActionResult Index()
        {
            return View(ColumnTable.Columns);
        }

        //
        // POST: /Search/GetInitData
        public ActionResult GetInitData()
        {
            var section = sectionLoader.Load();
            var model = sectionConverter.Convert(section);
            return Json(new 
            {
                data = JsonConvert.SerializeObject(model, GetJsonSettings())
            });
        }

        //
        // POST: /Search/GetSectionData
        public ActionResult GetSectionData(int sectionId)
        {
            return new EmptyResult();
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