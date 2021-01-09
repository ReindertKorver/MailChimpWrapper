using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
	public class Timewarp
	{
		[JsonPropertyName("gmt_offset")]
		public int GmtOffset { get; set; }

		[JsonPropertyName("opens")]
		public int Opens { get; set; }

		[JsonPropertyName("last_open")]
		public string LastOpen { get; set; }

		[JsonPropertyName("unique_opens")]
		public int UniqueOpens { get; set; }

		[JsonPropertyName("clicks")]
		public int Clicks { get; set; }

		[JsonPropertyName("last_click")]
		public string LastClick { get; set; }

		[JsonPropertyName("unique_clicks")]
		public int UniqueClicks { get; set; }

		[JsonPropertyName("bounces")]
		public int Bounces { get; set; }
	}
}