// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) Anton Hirov

using System.Collections.Generic;
using Newtonsoft.Json;

namespace SearchKit.Entities.Search
{
    [JsonObject(MemberSerialization.OptIn)]
    public class SectionModel : JsonReference
    {
        public SectionModel()
        {
            Children = new List<SectionModel>();
            Items = new List<ItemModel>();
        }

        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonConverter(typeof(ReferenceConverter))]
        [JsonProperty("parent", Required = Required.AllowNull)]
        public SectionModel Parent { get; set; }

        [JsonProperty("children", Required = Required.Always)]
        public List<SectionModel> Children { get; }

        [JsonProperty("items", Required = Required.Always)]
        public List<ItemModel> Items { get; }
    }
}