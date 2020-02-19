// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) Anton Hirov

using System.Data.Entity;

namespace SearchKit.Data.Entities
{
    public class SearchKitDbContext : DbContext
    {
        public SearchKitDbContext() : base("SearchKitDbConnection")
        {
            Database.SetInitializer(new SearchKitDbInitializer());
            Database.Initialize(true);
        }

        public DbSet<SectionData> SectionDataSet { get; set; }
        public DbSet<ItemData> ItemDataSet { get; set; }
    }
}