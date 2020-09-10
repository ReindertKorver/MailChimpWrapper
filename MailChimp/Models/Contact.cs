﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
    public class Contact
    {
        [JsonPropertyName("company")]
        public string Company { get; set; }
        [JsonPropertyName("address1")]

        public string Address1 { get; set; }
        [JsonPropertyName("address2")]

        public string Address2 { get; set; }
        [JsonPropertyName("city")]

        public string City { get; set; }
        [JsonPropertyName("state")]

        public string State { get; set; }
        [JsonPropertyName("zip")]

        public string Zip { get; set; }
        [JsonPropertyName("country")]

        public string Country { get; set; }
        [JsonPropertyName("phone")]

        public string Phone { get; set; }
    }
}
