using System.Text.Json.Serialization;
using MailChimpWrapper.Models.Requests;

namespace MailChimpWrapper.Models.Responses
{
    ///<summary>
    /// This is the result of a request:
    /// <para>
    /// <see cref="PingGetRequest"></see>
    /// </para>
    /// </summary>
    public class PingResponse : IBaseResponse
    {
        [JsonPropertyName("health_status")]
        public string HealthStatus { get; set; }

        public int Status { get; set; }
    }
}