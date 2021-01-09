using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
	public class Timesery
	{
		[JsonPropertyName("timestamp")]
		public string Timestamp { get; set; }

		[JsonPropertyName("emails_sent")]
		public long EmailsSent { get; set; }

		[JsonPropertyName("unique_opens")]
		public long UniqueOpens { get; set; }

		[JsonPropertyName("recipients_clicks")]
		public long RecipientsClicks { get; set; }
	}
}