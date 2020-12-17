using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
    public class VariateContent
    {
        [JsonPropertyName("content_label")]
        public string ContentLabel { get; set; }

        [JsonPropertyName("plain_text")]
        public string PlainText { get; set; }

        [JsonPropertyName("html")]
        public string Html { get; set; }
    }
}