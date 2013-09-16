using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MailChimp.Lists
{
    /// <summary>
    /// Error message from merge vars.
    /// </summary>
    [DataContract]
    public class MergeVarError
    {
        /// <summary>
        /// the passed list id that failed
        /// </summary>
        [DataMember(Name = "id")]
        public string ListId
        {
            get;
            set;
        }

        /// <summary>
        /// the error code
        /// </summary>
        [DataMember(Name = "code")]
        public int ErrorCode
        {
            get;
            set;
        }

        /// <summary>
        /// the full error message
        /// </summary>
        [DataMember(Name = "msg")]
        public string ErrorMessage
        {
            get;
            set;
        }
    }
}
