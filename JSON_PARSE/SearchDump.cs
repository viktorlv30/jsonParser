using System.Runtime.Serialization;

namespace JSON_PARSE
{
    [DataContract]
    public class SearchDump
    {
        [DataMember(Name = "product")]
        public Product Product { get; set; }
    }
}