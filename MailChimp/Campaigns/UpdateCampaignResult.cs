using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.Campaigns
{
    [DataContract]
    public class UpdateCampaignResult
    {
        [DataMember(Name = "data")]
        public Campaign Campaign { get; set; }

        /// <summary>
        /// for "options" only
        /// </summary>
        [DataMember(Name = "errors")]
        public List<UpdateCampaignError> Errors { get; set; }
    }
}