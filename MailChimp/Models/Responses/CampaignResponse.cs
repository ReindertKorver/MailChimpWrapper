using System;
using System.Collections.Generic;
using System.Text;

namespace MailChimpWrapper.Models.Responses
{
    public class CampaignResponse : Campaign
    {
        public string Status { get; set; }
    }
}