using System;
using System.Collections.Generic;
using System.Text;

namespace MailChimpWrapper.Models.Responses
{
    public class CampaignContentResponse : CampaignContent, IBaseResponse
    {
        public int Status { get; set; }
    }
}