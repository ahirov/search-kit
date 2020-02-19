// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) Anton Hirov

using System;
using System.Collections.Generic;
using System.Data.Entity;
using SearchKit.Data.Entities;

namespace SearchKit.Data
{
    public class SearchKitDbInitializer : DropCreateDatabaseIfModelChanges<SearchKitDbContext>
    {
        protected override void Seed(SearchKitDbContext context)
        {
            var rootSection = new SectionData
            {
                Name = "Root"
            };
            rootSection.Items.Add(new ItemData { Name = "Item.0.1" });
            rootSection.Items.Add(new ItemData { Name = "Item.0.2" });
            var children = rootSection.Children;
            var section1 = new SectionData
            {
                Name = "Section1",
                Parent = rootSection
            };
            section1.Items.Add(new ItemData { Name = "Item.1.1" });
            section1.Items.Add(new ItemData { Name = "Item.1.2" });
            children.Add(section1);

            var section2 = new SectionData
            {
                Name = "Section2",
                Parent = rootSection
            };
            section2.Items.Add(new ItemData { Name = "Item.2.1" });
            section2.Items.Add(new ItemData { Name = "Item.2.2" });
            children.Add(section2);
            children.Add(new SectionData
            {
                Name = "Section3",
                Parent = rootSection
            });
            context.SectionDataSet.Add(rootSection);
            base.Seed(context);
        }
    }
}