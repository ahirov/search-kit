// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) Anton Hirov

using Newtonsoft.Json;

namespace SearchKit.Entities.Search
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ItemModel : JsonReference
    {
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }
    }
}