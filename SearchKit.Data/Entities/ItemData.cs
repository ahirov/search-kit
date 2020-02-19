// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) Anton Hirov

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchKit.Data.Entities
{
    public class ItemData
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Section")]
        public int SectionId { get; set; }
        public SectionData Section { get; set; }
    }
}