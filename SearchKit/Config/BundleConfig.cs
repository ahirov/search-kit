// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) 2018 Anton Hirov

using System.Web.Optimization;
using SearchKit.Core;

namespace SearchKit
{
    public class BundleConfig
    {
        public static void Register(BundleCollection bundles)
        {
            var css = new StyleBundle("~/bundles/css");
            var js = new ScriptBundle("~/bundles/js");
            bundles.Add(css);
            bundles.Add(js);

            var cssPattern = CodeConstants.CssLiteral.GetSearchPattern();
            css.IncludeDirectory("~/Styles/dependencies/", cssPattern, true);
            css.IncludeDirectory("~/Styles/global/",       cssPattern, true);
            css.IncludeDirectory("~/Styles/search/",       cssPattern, true);

            var jsPattern = CodeConstants.JsLiteral.GetSearchPattern();
            js.IncludeDirectory("~/Scripts/dependencies/", jsPattern, true);
            js.IncludeDirectory("~/Scripts/global/",       jsPattern, true);
            js.IncludeDirectory("~/Scripts/search/",       jsPattern, true);
        }
    }
}