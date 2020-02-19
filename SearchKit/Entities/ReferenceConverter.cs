// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) Anton Hirov

using System;
using Newtonsoft.Json;

namespace SearchKit.Entities
{
    public class ReferenceConverter : JsonConverter
    {
        public override bool CanRead => false;

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsClass;
        }

        public override void WriteJson(JsonWriter writer,
                                       object value,
                                       JsonSerializer serializer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("$ref");
            writer.WriteValue(GetId(value));
            writer.WriteEndObject();
        }

        public override object ReadJson(JsonReader reader,
                                        Type objectType,
                                        object existingValue,
                                        JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        private static string GetId(object obj)
        {
            var prop = obj.GetType().GetProperty("Id", typeof(string));
            return prop != null && prop.CanRead
                ? (string)prop.GetValue(obj, null)
                : string.Empty;
        }
    }
}