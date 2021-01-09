using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
	public class ListStats
	{
		[JsonPropertyName("sub_rate")]
		public long SubRate { get; set; }

		[JsonPropertyName("unsub_rate")]
		public long UnsubRate { get; set; }

		[JsonPropertyName("open_rate")]
		public long OpenRate { get; set; }

		[JsonPropertyName("click_rate")]
		public long ClickRate { get; set; }
	}
}