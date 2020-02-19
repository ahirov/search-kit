// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) Anton Hirov

using System.Data.Entity;
using System.Linq;
using SearchKit.Data.Entities;

namespace SearchKit.Data
{
    public class SearchKitDbProcessor
    {
        public SectionData Get()
        {
            using (var ctx = new SearchKitDbContext())
            {
                var items = ctx.SectionDataSet.Include(_ => _.Items).ToList();
                return items.Any() ? items.First() : null;
            }
        }
    }
}