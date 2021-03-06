﻿
// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Blockchair.Net.Objects;
//
//    var blockchair = Blockchair.FromJson(jsonString);

namespace Blockchair.Net.Objects
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
  
    public partial class BlockchairResponse<T>
    {
        [JsonProperty("data")]
        public T Data { get; set; }

        [JsonProperty("context")]
        public Context Context { get; set; }
    }
    public  class AddressInfoResult
    {
        [JsonProperty("data")]
        public Dictionary<string, AddressInfo> Resultiq { get; set; }

        [JsonProperty("context")]
        public Context Context { get; set; }
    }

    public partial class Context
    {
        [JsonProperty("code")]
        public long Code { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("time")]
        public double Time { get; set; }

        [JsonProperty("limit")]
        public long Limit { get; set; }

        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("results")]
        public long Results { get; set; }

        [JsonProperty("state")]
        public long State { get; set; }

        [JsonProperty("cache")]
        public Cache Cache { get; set; }

        [JsonProperty("api")]
        public Api Api { get; set; }
    }

    public partial class Api
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("last_major_update")]
        public DateTimeOffset LastMajorUpdate { get; set; }

        [JsonProperty("next_major_update")]
        public object NextMajorUpdate { get; set; }

        [JsonProperty("tested_features")]
        public string TestedFeatures { get; set; }

        [JsonProperty("documentation")]
        public Uri Documentation { get; set; }
    }

    public partial class Cache
    {
        [JsonProperty("live")]
        public bool Live { get; set; }

        [JsonProperty("duration")]
        public long? Duration { get; set; }

        [JsonProperty("since")]
        public DateTimeOffset? Since { get; set; }

        [JsonProperty("until")]
        public DateTimeOffset? Until { get; set; }

        [JsonProperty("time")]
        public double? Time { get; set; }
    }



    //public partial class Blockchair
    //{
    //    public static Blockchair FromJson(string json) => JsonConvert.DeserializeObject<Blockchair>(json, Blockchair.Net.Objects.Converter.Settings);
    //}

    //public static class Serialize
    //{
    //    public static string ToJson(this Blockchair self) => JsonConvert.SerializeObject(self, Blockchair.Net.Objects.Converter.Settings);
    //}

    //internal static class Converter
    //{
    //    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    //    {
    //        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
    //        DateParseHandling = DateParseHandling.None,
    //        Converters =
    //        {
    //            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
    //        },
    //    };
    //}
}

