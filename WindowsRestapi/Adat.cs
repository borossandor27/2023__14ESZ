﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using _2024_03_05_sync_async;
//
//    var adat = Adat.FromJson(jsonString);
using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WindowsRestapi
{
    
    public partial class Adat
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("salary")]
        public long Salary { get; set; }
    }

    public partial class Adat
    {
        public static Adat[] FromJson(string json) => JsonConvert.DeserializeObject<Adat[]>(json, WindowsRestapi.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Adat[] self) => JsonConvert.SerializeObject(self, WindowsRestapi.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
