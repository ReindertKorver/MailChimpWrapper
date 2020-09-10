using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
    public class Interests
    {
        [JsonPropertyName("property1")]
        public bool? Property1 { get; set; }

        [JsonPropertyName("property2")]
        public bool? Property2 { get; set; }
    }
}