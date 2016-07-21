using System.Runtime.Serialization;

namespace JSON_PARSE
{
    [DataContract]
    public class Product
    {
        [DataMember(Name = "sys")]
        public string Sys { get; set; }

        [DataMember(Name="id")]
        public int Id { get; set; }

        [DataMember(Name = "provider_id")]
        public int ProviderId { get; set; }

        [DataMember(Name = "company_id")]
        public int CompanyId { get; set; }

        [DataMember(Name = "short")]
        public string @Short { get; set; }

        [DataMember(Name = "record_id")]
        public int RecordId { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }
        [DataMember(Name = "seotext")]
        public string SeoText { get; set; }
        [DataMember(Name = "csys")]
        public string CSys { get; set; }
        [DataMember(Name = "cshort")]
        public string CShort { get; set; }
        [DataMember(Name="ccode")]
        public int CCode { get; set; }
    }
}