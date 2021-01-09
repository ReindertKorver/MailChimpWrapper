using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
	public class Opens
	{
		[JsonPropertyName("opens_total")]
		public long OpensTotal { get; set; }

		[JsonPropertyName("unique_opens")]
		public long UniqueOpens { get; set; }

		[JsonPropertyName("open_rate")]
		public long OpenRate { get; set; }

		[JsonPropertyName("last_open")]
		public string LastOpen { get; set; }
	}
}