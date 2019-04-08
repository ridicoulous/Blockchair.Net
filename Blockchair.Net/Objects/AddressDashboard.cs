using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Blockchair.Net.Objects
{
    //public static class DataContractSerializer
    //{
    //    public static Dictionary<string, AddressInfo> GetAddressInfo(string json)
    //    {
    //        Dictionary<string, AddressInfo> myDictionary;
    //        using (MemoryStream jStream = new MemoryStream(Encoding.Unicode.GetBytes(json)))
    //        {
    //            DataContractJsonSerializerSettings settings = new DataContractJsonSerializerSettings();
    //            settings.UseSimpleDictionaryFormat = true;

    //            var serializer = new DataContractJsonSerializer(typeof(Dictionary<string, AddressInfo>), settings);
    //            myDictionary = serializer.ReadObject(jStream) as Dictionary<string, AddressInfo>;
    //        }

    //        return myDictionary;
    //    }
    //}

    [JsonDictionary]
    public partial class AddressDashboard
    {
        public Dictionary<string, AddressInfo> data { get; set; }
    }

    public partial class AddressInfo
    {
        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("transactions")]
        public List<string> Transactions { get; set; }
    }

    public partial class Address
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("script_hex")]
        public string ScriptHex { get; set; }

        [JsonProperty("balance")]
        public long Balance { get; set; }

        [JsonProperty("balance_usd")]
        public long BalanceUsd { get; set; }

        [JsonProperty("received")]
        public long Received { get; set; }

        [JsonProperty("received_usd")]
        public double ReceivedUsd { get; set; }

        [JsonProperty("spent")]
        public long Spent { get; set; }

        [JsonProperty("spent_usd")]
        public double SpentUsd { get; set; }

        [JsonProperty("output_count")]
        public long OutputCount { get; set; }

        [JsonProperty("unspent_output_count")]
        public long UnspentOutputCount { get; set; }

        [JsonProperty("first_seen_receiving")]
        public DateTimeOffset? FirstSeenReceiving { get; set; }

        [JsonProperty("last_seen_receiving")]
        public DateTimeOffset? LastSeenReceiving { get; set; }

        [JsonProperty("first_seen_spending")]
        public DateTimeOffset? FirstSeenSpending { get; set; }

        [JsonProperty("last_seen_spending")]
        public DateTimeOffset? LastSeenSpending { get; set; }

        [JsonProperty("transaction_count")]
        public long TransactionCount { get; set; }
    }
}
