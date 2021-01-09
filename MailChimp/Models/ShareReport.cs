using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
	public class ShareReport
	{
		[JsonPropertyName("share_url")]
		public string ShareUrl { get; set; }

		[JsonPropertyName("share_password")]
		public string SharePassword { get; set; }
	}
}