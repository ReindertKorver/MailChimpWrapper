using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
	public class FacebookLikes
	{
		[JsonPropertyName("recipient_likes")]
		public long RecipientLikes { get; set; }

		[JsonPropertyName("unique_likes")]
		public long UniqueLikes { get; set; }

		[JsonPropertyName("facebook_likes")]
		public long FacebookLikesFacebookLikes { get; set; }
	}
}