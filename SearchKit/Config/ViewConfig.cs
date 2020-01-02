// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) 2018 Anton Hirov

using System;
using System.Collections.Generic;
using System.Linq;
using SearchKit.Entities.View;

namespace SearchKit
{
    public static class ColumnTable
    {
        static ColumnTable()
        {
            Columns = new ColumnCollection();
        }

        public static ColumnCollection Columns { get; set; }
    }

    public class ViewConfig
    {
        public static void Register(ColumnCollection columns)
        {
            if (!columns.Any())
            {
                SeedColumns(columns);
                CheckColumns(columns);
            }
        }

        private static void SeedColumns(ColumnCollection columns)
        {
            columns.AddRange(new ColumnCollection
            {
                new Column {Name = "Sections",    Width = 3, Type = ColumnType.InitialSection},
                new Column {Name = "Subsections", Width = 3, Type = ColumnType.FinalSection},
                new Column {Name = "Items",       Width = 6, Type = ColumnType.Items}
            });
        }

        private static void CheckColumns(ColumnCollection columns)
        {
            var count = columns.Count;
            if (count < 3 || count > 12)
                throw new InvalidOperationException("Total count should from 3 to 12!");

            var totalWidth = columns.Sum(_ => _.Width);
            if (totalWidth != 12)
                throw new InvalidOperationException("Total width should be 12!");

            var requiredTypes = new List<ColumnType>
            {
                ColumnType.InitialSection,
                ColumnType.FinalSection,
                ColumnType.Items
            };
            if (requiredTypes.Any(t => columns.All(_ => _.Type != t)))
                throw new InvalidOperationException("Required columns not found!");

            var columnsScheme = new Dictionary<ColumnType, List<ColumnType>>
            {
                {ColumnType.None,                new List<ColumnType> {ColumnType.InitialSection}},
                {ColumnType.InitialSection,      new List<ColumnType> {ColumnType.IntermediateSection,
                                                                       ColumnType.FinalSection}},
                {ColumnType.IntermediateSection, new List<ColumnType> {ColumnType.IntermediateSection,
                                                                       ColumnType.FinalSection}},
                {ColumnType.FinalSection,        new List<ColumnType> {ColumnType.Items}}
            };

            var lastType = ColumnType.None;
            foreach (var column in columns)
            {
                if (!columnsScheme.ContainsKey(lastType)
                  || columnsScheme[lastType].All(_ => _ != column.Type))
                {
                    throw new InvalidOperationException("Invalid columns order!");
                }
                lastType = column.Type;
            }
        }
    }
}