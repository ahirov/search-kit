// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) 2018 Anton Hirov

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SearchKit.Entities.Search
{
    [JsonObject(MemberSerialization.OptIn)]
    public class PaperOverview : JsonReference
    {
        public PaperOverview()
        {
            Authors = new List<AuthorOverview>();
        }

        [JsonProperty("isActivated",  Required = Required.Always)]
        public bool IsActivated { get; set; }

        [JsonProperty("name",         Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("dateCreated",  Required = Required.Always)]
        public DateTime DateCreated { get; set; }

        [JsonProperty("dateModified", Required = Required.Always)]
        public DateTime DateModified { get; set; }

        [JsonProperty("owner",        Required = Required.Always)]
        public AuthorOverview Owner { get; set; }

        [JsonProperty("authors",      Required = Required.Always)]
        public List<AuthorOverview> Authors { get; }
    }
}