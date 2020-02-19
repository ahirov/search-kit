// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) Anton Hirov

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SearchKit.Data.Entities
{
    public class SectionData
    {
        public SectionData()
        {
            Children = new HashSet<SectionData>();
            Items = new HashSet<ItemData>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public SectionData Parent { get; set; }
        public ICollection<SectionData> Children { get; }
        public ICollection<ItemData> Items { get; }
    }
}