using GroupDocs.Conversion.MVC.Products.Common.Entity.Web;
using Newtonsoft.Json;

namespace GroupDocs.Conversion.MVC.Products.Conversion.Entity.Web.Request
{
    public class ConversionPostedData : PostedDataEntity
    {
        [JsonProperty]
        private string destinationType { get; set; }

        [JsonProperty]
        private string destDocumentType { get; set; }

        public string GetDestinationType()
        {
            return this.destinationType;
        }

        public void SetDestinationType(string type)
        {
            this.destinationType = type;
        }

        public string GetDestDocumentType()
        {
            return this.destDocumentType;
        }

        public void SetDestDocumentType(string type)
        {
            this.destDocumentType = type;
        }
    }
}