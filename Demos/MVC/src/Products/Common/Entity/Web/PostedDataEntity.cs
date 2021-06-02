using System.Collections.Generic;

namespace GroupDocs.Conversion.MVC.Products.Common.Entity.Web
{
    /// <summary>
    /// Posted data entity
    /// </summary>
    public class PostedDataEntity
    {
        public string path { get; set; }
        public string guid { get; set; }     
        public string password { get; set; }
        public string url { get; set; }
        public int page { get; set; }
        public int angle { get; set; }
        public List<int> pages { get; set; }        
        public bool rewrite { get; set; }        
    }
}