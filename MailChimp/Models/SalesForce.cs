using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
    public class SalesForce
    {
        [JsonPropertyName("campaign")]
        public bool Campaign { get; set; }

        [JsonPropertyName("notes")]
        public bool Notes { get; set; }
    }
}