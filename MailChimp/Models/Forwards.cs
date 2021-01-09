using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
	public class Forwards
	{
		[JsonPropertyName("forwards_count")]
		public long ForwardsCount { get; set; }

		[JsonPropertyName("forwards_opens")]
		public long ForwardsOpens { get; set; }
	}
}