// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) Anton Hirov

using System.Collections.Generic;

namespace SearchKit.Entities.View
{
    public enum ColumnType
    {
        InitialSection      = 1,
        IntermediateSection = 2,
        FinalSection        = 3,
        Items               = 4
    }

    public class Column
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Width { get; set; }
        public ColumnType Type { get; set; }
    }

    public class ColumnCollection : List<Column> { }
}