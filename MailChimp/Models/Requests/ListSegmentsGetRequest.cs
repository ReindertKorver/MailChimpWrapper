using MailChimpWrapper.Models.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using MailChimpWrapper.Models.Responses;

namespace MailChimpWrapper.Models.Requests
{
	/// <summary>
	/// Get information about all available segments for a specific list.
	/// <para>
	/// <see href="https://mailchimp.com/developer/api/marketing/list-segments/list-segments/">Docs /lists/{list_id}/segments</see>
	/// </para>
	/// <para>
	/// Result of this request will be of type <see cref="ListSegmentsResponse"/>
	/// </para>
	/// </summary>
	public class ListSegmentsGetRequest : IBaseRequest
	{
		internal readonly string _queryParams;
		private readonly string _listId;

		public ListSegmentsGetRequest(string listId, string queryParams = "")
		{
			_queryParams = queryParams;
			_listId = listId;
		}

		string IBaseRequest.Endpoint { get => $"{Endpoints.Lists}/{_listId}/segments{_queryParams}"; }
		HttpMethod IBaseRequest.Method { get => HttpMethod.Get; }
	}
}