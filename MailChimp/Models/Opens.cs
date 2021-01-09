using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
	public class Opens
	{
		[JsonPropertyName("opens_total")]
		public int OpensTotal { get; set; }

		[JsonPropertyName("unique_opens")]
		public int UniqueOpens { get; set; }

		[JsonPropertyName("open_rate")]
		public int OpenRate { get; set; }

		[JsonPropertyName("last_open")]
		public string LastOpen { get; set; }
	}
}