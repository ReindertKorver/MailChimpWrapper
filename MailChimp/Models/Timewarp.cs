using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
	public class Timewarp
	{
		[JsonPropertyName("gmt_offset")]
		public long GmtOffset { get; set; }

		[JsonPropertyName("opens")]
		public long Opens { get; set; }

		[JsonPropertyName("last_open")]
		public string LastOpen { get; set; }

		[JsonPropertyName("unique_opens")]
		public long UniqueOpens { get; set; }

		[JsonPropertyName("clicks")]
		public long Clicks { get; set; }

		[JsonPropertyName("last_click")]
		public string LastClick { get; set; }

		[JsonPropertyName("unique_clicks")]
		public long UniqueClicks { get; set; }

		[JsonPropertyName("bounces")]
		public long Bounces { get; set; }
	}
}