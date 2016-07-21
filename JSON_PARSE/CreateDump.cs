using System.Runtime.Serialization;

namespace JSON_PARSE
{
    [DataContract]
    public class CreateDump
    {
        [DataMember(Name = "user")]
        public User User { get; set; }

    }
}