// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) Anton Hirov

using SearchKit.Data;
using SearchKit.Service.Converters;
using SearchKit.Service.Entities;

namespace SearchKit.Service
{
    public class SectionLoader
    {
        public Section Load()
        {
            var initializer = new SearchKitDbProcessor();
            var data = initializer.Get();

            return new SectionConverter().Convert(data);
        }
    }
}