using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
	public class DeliveryStatus
	{
		[JsonPropertyName("enabled")]
		public bool Enabled { get; set; }

		[JsonPropertyName("can_cancel")]
		public bool CanCancel { get; set; }

		[JsonPropertyName("status")]
		public string Status { get; set; }

		[JsonPropertyName("emails_sent")]
		public long EmailsSent { get; set; }

		[JsonPropertyName("emails_canceled")]
		public long EmailsCanceled { get; set; }
	}
}