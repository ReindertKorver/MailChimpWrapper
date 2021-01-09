using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
	public class FacebookLikes
	{
		[JsonPropertyName("recipient_likes")]
		public int RecipientLikes { get; set; }

		[JsonPropertyName("unique_likes")]
		public int UniqueLikes { get; set; }

		[JsonPropertyName("facebook_likes")]
		public int FacebookLikesFacebookLikes { get; set; }
	}
}