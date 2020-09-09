using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models.Responses
{
    public class PingResponse:IBaseResponse
    {
        [JsonPropertyName("health_status")]
        public string HealthStatus { get; set; }
        public int Status { get; set; }
    }
}