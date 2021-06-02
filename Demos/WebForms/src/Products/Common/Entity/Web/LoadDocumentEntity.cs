using Newtonsoft.Json;
using System.Collections.Generic;

namespace GroupDocs.Conversion.WebForms.Products.Common.Entity.Web
{
    public class LoadDocumentEntity
    {
        ///Document Guid
        [JsonProperty]
        private string guid;

        ///list of pages        
        [JsonProperty]
        private List<PageDescriptionEntity> pages = new List<PageDescriptionEntity>();

        ///Document Guid
        [JsonProperty]
        private bool printAllowed = true;

        public void SetPrintAllowed(bool allowed)
        {
            this.printAllowed = allowed;
        }

        public bool GetPrintAllowed()
        {
            return this.printAllowed;
        }

        public void SetGuid(string guid)
        {
            this.guid = guid;
        }

        public string GetGuid()
        {
            return guid;
        }

        public void SetPages(PageDescriptionEntity page)
        {
            this.pages.Add(page);
        }

        public List<PageDescriptionEntity> GetPages()
        {
            return pages;
        }
    }
}