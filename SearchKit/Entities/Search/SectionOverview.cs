// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) 2018 Anton Hirov

using System.Collections.Generic;
using Newtonsoft.Json;

namespace SearchKit.Entities.Search
{
    [JsonObject(MemberSerialization.OptIn)]
    public class SectionOverview : JsonReference
    {
        public SectionOverview()
        {
            Children = new List<SectionOverview>();
            Papers = new List<PaperOverview>();
        }

        [JsonProperty("isActivated", Required = Required.Always)]
        public bool IsActivated { get; set; }

        [JsonProperty("name",        Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("author",      Required = Required.Always)]
        public AuthorOverview Author { get; set; }

        [JsonConverter(typeof(ReferenceConverter))]
        [JsonProperty("parent",      Required = Required.AllowNull)]
        public SectionOverview Parent { get; set; }

        [JsonProperty("children",    Required = Required.Always)]
        public List<SectionOverview> Children { get; }

        [JsonProperty("papers",      Required = Required.Always)]
        public List<PaperOverview> Papers { get; }
    }
}