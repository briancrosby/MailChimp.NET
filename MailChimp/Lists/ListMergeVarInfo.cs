using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.Lists
{
    [DataContract]
    public class ListMergeVarInfo
    {
        [DataMember(Name = "id")]
        public string ListId { get; set; }

        [DataMember(Name = "name")]
        public string ListName { get; set; }

        /// <summary>
        /// List of merge vars
        /// </summary>
        [DataMember(Name = "merge_vars")]
        public List<MergeVarInfo> MergeVars { get; set; }
    }
}