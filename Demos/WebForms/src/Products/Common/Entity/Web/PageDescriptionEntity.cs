
using Newtonsoft.Json;

namespace GroupDocs.Conversion.WebForms.Products.Common.Entity.Web
{
    /// <summary>
    /// DocumentDescriptionEntity
    /// </summary>
    public class PageDescriptionEntity
    {
        public double width { get; set; }
        public double height { get; set; }
        public int number { get; set; }
        public int angle { get; set; }

        [JsonProperty]
        private string data;

        public void SetData(string data)
        {
            this.data = data;
        }

        public string GetData()
        {
            return data;
        }
    }
}