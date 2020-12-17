using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models.Responses
{
	public class BatchSubscribeUnsubscribeResponse
	{
		[JsonPropertyName("new_members")]
		public Member[] NewMembers { get; set; }

		[JsonPropertyName("updated_members")]
		public Member[] UpdatedMembers { get; set; }

		[JsonPropertyName("errors")]
		public MemberError[] Errors { get; set; }

		[JsonPropertyName("total_created")]
		public long TotalCreated { get; set; }

		[JsonPropertyName("total_updated")]
		public long TotalUpdated { get; set; }

		[JsonPropertyName("error_count")]
		public long ErrorCount { get; set; }

		[JsonPropertyName("_links")]
		public Link[] Links { get; set; }
	}
}