using System;
using System.Collections.Generic;
using System.Text;
using MailChimpWrapper.Models.Requests;

namespace MailChimpWrapper.Models.Responses
{
    ///<summary>
    /// This is the result of a request:
    /// <para>
    /// <see cref="CampaignGetRequest"></see>, <see cref="CampaignEditRequest"></see> and <see cref="CampaignNewPostRequest"></see>
    /// </para>
    /// </summary>
    public class CampaignResponse : Campaign
    {
        public string Status { get; set; }
    }
}