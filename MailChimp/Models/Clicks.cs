using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
	public class Clicks
	{
		[JsonPropertyName("clicks_total")]
		public long ClicksTotal { get; set; }

		[JsonPropertyName("unique_clicks")]
		public long UniqueClicks { get; set; }

		[JsonPropertyName("unique_subscriber_clicks")]
		public long UniqueSubscriberClicks { get; set; }

		[JsonPropertyName("click_rate")]
		public long ClickRate { get; set; }

		[JsonPropertyName("last_click")]
		public string LastClick { get; set; }
	}
}