using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
    public class Archive
    {
        [JsonPropertyName("archive_content")]
        public string ArchiveContent { get; set; }

        [JsonPropertyName("archive_type")]
        public string ArchiveType { get; set; }
    }
}