using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MailChimpWrapper.Models.Requests
{
    /// <summary>
    /// Create a new list in your Mailchimp account.
    /// <para>
    /// <see href="https://mailchimp.com/developer/api/marketing/lists/add-list/">Docs /lists</see>
    /// </para>
    /// </summary>
    public class ListsPostRequest : SubscriberList, IBaseRequest
    {
        public ListsPostRequest()
        {
        }

        public ListsPostRequest(string name, Contact contact, string permissionReminder, CampaignDefaults campaignDefaults, bool emailTypeOption)
        {
            Name = name;
            Contact = contact;
            PermissionReminder = permissionReminder;
            CampaignDefaults = campaignDefaults;
            EmailTypeOption = emailTypeOption;
        }

        string IBaseRequest.Endpoint { get => Endpoints.Lists; }
        HttpMethod IBaseRequest.Method { get => HttpMethod.Post; }
    }
}