using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
	public class ListStats
	{
		[JsonPropertyName("sub_rate")]
		public int SubRate { get; set; }

		[JsonPropertyName("unsub_rate")]
		public int UnsubRate { get; set; }

		[JsonPropertyName("open_rate")]
		public int OpenRate { get; set; }

		[JsonPropertyName("click_rate")]
		public int ClickRate { get; set; }
	}
}