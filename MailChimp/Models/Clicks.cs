using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
	public class Clicks
	{
		[JsonPropertyName("clicks_total")]
		public int ClicksTotal { get; set; }

		[JsonPropertyName("unique_clicks")]
		public int UniqueClicks { get; set; }

		[JsonPropertyName("unique_subscriber_clicks")]
		public int UniqueSubscriberClicks { get; set; }

		[JsonPropertyName("click_rate")]
		public int ClickRate { get; set; }

		[JsonPropertyName("last_click")]
		public string LastClick { get; set; }
	}
}