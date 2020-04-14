// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) Anton Hirov

using System.Data.Entity;
using System.Linq;
using SearchKit.Data.Entities;

namespace SearchKit.Data
{
    public interface IDataProvider
    {
        SectionData GetSection();
    }

    public class DataProvider : IDataProvider
    {
        private readonly ISearchKitDbContext context;

        public DataProvider(ISearchKitDbContext context)
        {
            this.context = context;
        }

        public SectionData GetSection()
        {
            var items = context.SectionDataSet
                               .Include(_ => _.Items)
                               .ToList();
            return items.Any()
                ? items.First()
                : null;
        }
    }
}