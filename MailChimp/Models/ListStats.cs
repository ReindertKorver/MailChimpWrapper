using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
	public class ListStats
	{
		[JsonPropertyName("sub_rate")]
		public double SubRate { get; set; }

		[JsonPropertyName("unsub_rate")]
		public double UnsubRate { get; set; }

		[JsonPropertyName("open_rate")]
		public double OpenRate { get; set; }

		[JsonPropertyName("click_rate")]
		public double ClickRate { get; set; }
	}
}