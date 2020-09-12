using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
    public class Capsule
    {
        [JsonPropertyName("notes")]
        public bool Notes { get; set; }
    }
}