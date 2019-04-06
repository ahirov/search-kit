// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) 2018 Anton Hirov

using Newtonsoft.Json;

namespace SearchKit.Entities
{
    public abstract class JsonReference
    {
        [JsonProperty("$id", Required = Required.Default)]
        public string Id { get; set; }
    }
}