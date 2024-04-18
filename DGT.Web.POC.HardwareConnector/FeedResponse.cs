using System.Text.Json;
using System.Text.Json.Serialization;

namespace DGT.Web.POC.HardwareConnector
{
    internal /*sealed*/ /*record*/ class LiveChessFeedResponse
    {
        internal static (string JsonString, LiveChessFeedResponse Response) Deserialize(string jsonString)
        {
            return (jsonString, JsonSerializer.Deserialize<LiveChessFeedResponse>(jsonString));
        }

        [JsonPropertyName("response")]
        public string Response { get; set; } = string.Empty;
        [JsonPropertyName("id")]
        public int Id { get; set; } = 0;
        [JsonPropertyName("param")]
        public LiveChessResponseParams Param { get; set; }
        [JsonPropertyName("time")]
        public long Time { get; set; }
    }

    internal /*sealed*/ /*record*/ class LiveChessResponseParams
    {
        [JsonPropertyName("serialnr")]
        public string Serialnr { get; set; }
        [JsonPropertyName("flipped")]
        public bool Flipped { get; set; }
        [JsonPropertyName("board")]
        public string Board { get; set; }
        [JsonPropertyName("clock")]
        public object Clock { get; set; }
    }
}
