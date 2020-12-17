using MailChimpWrapper.Models.Utils;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using MailChimpWrapper.Models.Responses;

namespace MailChimpWrapper.Models.Requests
{
	/// <summary>
	/// Add or remove tags from a list member. If a tag that does not exist is passed in and set as 'active', a new tag will be created.
	/// <para>
	/// <see href="https://mailchimp.com/developer/api/marketing/list-member-tags/add-or-remove-member-tags/">Docs /lists/{list_id}/members/{subscriber_hash}/tags</see>
	/// </para>
	/// <para>
	/// Result of this request will be of type <see cref="EmptyResponse"/>
	/// </para>
	/// </summary>
	public class MemberTagsPostRequest : IBaseRequest
	{
		internal readonly string _queryParams;
		private readonly string _listId;
		internal readonly string _emailaddress;

		public MemberTagsPostRequest(string listId, string emailaddress, List<Tag> tags, string queryParams = "")
		{
			_queryParams = queryParams;
			_listId = listId;
			_emailaddress = emailaddress;
			Tags = tags;
		}

		string IBaseRequest.Endpoint { get => $"{Endpoints.Lists}/{_listId}/members/{Hasher.CreateHash(_emailaddress)}/tags{_queryParams}"; }
		HttpMethod IBaseRequest.Method { get => HttpMethod.Post; }

		/// <summary>
		/// A list of tags assigned to the list member.
		/// </summary>
		[JsonPropertyName("tags")]
		public List<Tag> Tags { get; set; }
	}
}