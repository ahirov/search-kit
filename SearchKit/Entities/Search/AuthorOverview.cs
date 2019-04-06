// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) 2018 Anton Hirov

using Newtonsoft.Json;

namespace SearchKit.Entities.Search
{
    [JsonObject(MemberSerialization.OptIn)]
    public class AuthorOverview : JsonReference
    {
        [JsonProperty("firstName", Required = Required.Always)]
        public string FirstName { get; set; }

        [JsonProperty("lastName",  Required = Required.Always)]
        public string LastName { get; set; }
    }
}