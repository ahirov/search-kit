// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) 2018 Anton Hirov

using System.Web.Mvc;

namespace SearchKit.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {
            return View();
        }
    }
}