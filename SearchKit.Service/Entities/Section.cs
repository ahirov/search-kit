// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) Anton Hirov

using System.Collections.Generic;

namespace SearchKit.Service.Entities
{
    public class Section
    {
        public Section()
        {
            Children = new List<Section>();
            Items = new List<Item>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public Section Parent { get; set; }
        public List<Section> Children { get; }
        public List<Item> Items { get; }
    }
}