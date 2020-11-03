using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
    public class TemplateContent
    {
        [JsonPropertyName("sections")]
        public Dictionary<string, string> Sections { get; set; }

        [JsonPropertyName("_links")]
        public Link[] Links { get; set; }
    }
}