using System.Runtime.Serialization;

namespace MailChimp.Lists
{
    /// <summary>
    /// Information about a list merge variable.
    /// </summary>
    [DataContract]
    public class MergeVarInfo
    {
        /// <summary>
        /// Name of the merge field.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Denotes whether the field is required (true) or not (false).
        /// </summary>
        [DataMember(Name = "req")]
        public bool IsRequired { get; set; }

        /// <summary>
        /// The "data type" of this merge var. One of the options accepted by field_type in lists/merge-var-add.
        /// </summary>
        [DataMember(Name = "field_type")]
        public string FieldType { get; set; }

        /// <summary>
        /// Whether or not this field is visible to list subscribers.
        /// </summary>
        [DataMember(Name = "public")]
        public bool IsPublic { get; set; }

        /// <summary>
        /// Whether the list owner has this field displayed on their list dashboard.
        /// </summary>
        [DataMember(Name = "show")]
        public bool IsShown { get; set; }

        /// <summary>
        /// The order the list owner has set this field to display in.
        /// </summary>
        [DataMember(Name = "order")]
        public string Order { get; set; }

        /// <summary>
        /// The default value the list owner has set for this field.
        /// </summary>
        [DataMember(Name = "default")]
        public string Default { get; set; }

        /// <summary>
        /// The helptext for this field.
        /// </summary>
        [DataMember(Name = "helptext")]
        public string HelpText { get; set; }

        /// <summary>
        /// The width of the field to be used.
        /// </summary>
        [DataMember(Name = "size")]
        public string Size { get; set; }

        /// <summary>
        /// The merge tag that's used for forms and listSubscribe() and listUpdateMember()
        /// </summary>
        [DataMember(Name = "tag")]
        public string Tag { get; set; }

        /// <summary>
        /// For radio and drop-down field types, an array of the options available.
        /// </summary>
        [DataMember(Name = "choices")]
        public object[] Choices { get; set; }

        /// <summary>
        /// An unchanging id for the merge var.
        /// </summary>
        [DataMember(Name = "id")]
        public int Id { get; set; }
    }
}