using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
	public class Bounces
	{
		[JsonPropertyName("hard_bounces")]
		public int HardBounces { get; set; }

		[JsonPropertyName("soft_bounces")]
		public int SoftBounces { get; set; }

		[JsonPropertyName("syntax_errors")]
		public int SyntaxErrors { get; set; }
	}
}