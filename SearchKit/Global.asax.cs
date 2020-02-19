// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) Anton Hirov

using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SearchKit
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.Register(RouteTable.Routes);
            BundleConfig.Register(BundleTable.Bundles);
            ViewConfig.Register(ColumnTable.Columns);
        }
    }
}