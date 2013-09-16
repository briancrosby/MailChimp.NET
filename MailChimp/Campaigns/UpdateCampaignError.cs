using System.Runtime.Serialization;

namespace MailChimp.Campaigns
{
    [DataContract]
    public class UpdateCampaignError
    {
        /// <summary>
        /// the error code
        /// </summary>
        [DataMember(Name = "code")]
        public int Code { get; set; }

        /// <summary>
        /// the full error message
        /// </summary>
        [DataMember(Name = "message")]
        public string Message { get; set; }

        /// <summary>
        /// the parameter name that failed
        /// </summary>
        [DataMember(Name = "name")]
        public string ParameterName { get; set; }
    }
}