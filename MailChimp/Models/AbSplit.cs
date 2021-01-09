using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
	public class AbSplit
	{
		[JsonPropertyName("a")]
		public AbSplitItem CampaignA { get; set; }

		[JsonPropertyName("b")]
		public AbSplitItem CampaignB { get; set; }
	}

	public class AbSplitItem
	{
		[JsonPropertyName("bounces")]
		public int Bounces { get; set; }

		[JsonPropertyName("abuse_reports")]
		public int AbuseReports { get; set; }

		[JsonPropertyName("unsubs")]
		public int Unsubs { get; set; }

		[JsonPropertyName("recipient_clicks")]
		public int RecipientClicks { get; set; }

		[JsonPropertyName("forwards")]
		public int Forwards { get; set; }

		[JsonPropertyName("forwards_opens")]
		public int ForwardsOpens { get; set; }

		[JsonPropertyName("opens")]
		public int Opens { get; set; }

		[JsonPropertyName("last_open")]
		public string LastOpen { get; set; }

		[JsonPropertyName("unique_opens")]
		public int UniqueOpens { get; set; }
	}
}