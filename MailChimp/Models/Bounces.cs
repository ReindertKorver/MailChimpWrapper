using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
	public class Bounces
	{
		[JsonPropertyName("hard_bounces")]
		public long HardBounces { get; set; }

		[JsonPropertyName("soft_bounces")]
		public long SoftBounces { get; set; }

		[JsonPropertyName("syntax_errors")]
		public long SyntaxErrors { get; set; }
	}
}