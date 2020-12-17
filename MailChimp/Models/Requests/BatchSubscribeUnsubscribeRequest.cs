using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using MailChimpWrapper.Models.Responses;

namespace MailChimpWrapper.Models.Requests
{
	/// <summary>
	/// Batch subscribe or unsubscribe list members.
	/// <para>
	/// <see href="https://mailchimp.com/developer/api/marketing/lists/batch-subscribe-or-unsubscribe/">Docs /lists/{list_id}</see>
	/// </para>
	/// <para>
	/// Result of this request will be of type <see cref="BatchSubscribeUnsubscribeResponse"/>
	/// </para>
	/// </summary>
	public class BatchSubscribeUnsubscribeRequest : IBaseRequest
	{
		private readonly string _queryParams;
		private readonly string _listId;

		[JsonPropertyName("update_existing")]
		public bool UpdateExisting { get; set; }

		[JsonPropertyName("members")]
		public List<Member> Members { get; set; }

		public BatchSubscribeUnsubscribeRequest(string listId, string queryParams = "")
		{
			_queryParams = queryParams;
			_listId = listId;
		}

		string IBaseRequest.Endpoint
		{
			get => Endpoints.Lists + "/" + _listId + "" + _queryParams;
		}

		HttpMethod IBaseRequest.Method
		{
			get => HttpMethod.Post;
		}
	}
}