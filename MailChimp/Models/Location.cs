using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
    public class Location
    {
        [JsonPropertyName("latitude")]
        public int Latitude { get; set; }

        [JsonPropertyName("intitude")]
        public int intitude { get; set; }

        [JsonPropertyName("gmtoff")]
        public int Gmtoff { get; set; }

        [JsonPropertyName("dstoff")]
        public int Dstoff { get; set; }

        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }
    }
}