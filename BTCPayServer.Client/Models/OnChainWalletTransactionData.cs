using System;
using System.Collections.Generic;
using BTCPayServer.JsonConverters;
using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace BTCPayServer.Client.Models
{
    public class OnChainWalletTransactionData
    {
        [JsonConverter(typeof(UInt256JsonConverter))]
        public uint256 TransactionHash { get; set; }

        public string Comment { get; set; }
        public Dictionary<string, LabelData> Labels { get; set; } = new Dictionary<string, LabelData>();

        [JsonConverter(typeof(NumericStringJsonConverter))]
        public decimal Amount { get; set; }

        [JsonConverter(typeof(UInt256JsonConverter))]
        public uint256 BlockHash { get; set; }

        [JsonConverter(typeof(NumericStringJsonConverter))]
        public int? BlockHeight { get; set; }

        public int Confirmations { get; set; }

        [JsonConverter(typeof(DateTimeToUnixTimeConverter))]
        public DateTimeOffset Timestamp { get; set; }

        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public TransactionStatus Status { get; set; }
    }
}
