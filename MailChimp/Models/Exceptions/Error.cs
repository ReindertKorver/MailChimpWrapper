using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models.Exceptions
{
    public class Error
    {
        [JsonPropertyName("field")]
        public string Field { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}