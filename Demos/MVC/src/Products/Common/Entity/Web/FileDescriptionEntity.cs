
namespace GroupDocs.Conversion.MVC.Products.Common.Entity.Web
{
    /// <summary>
    /// File description entity
    /// </summary>
    public class FileDescriptionEntity
    {
        public string guid{ get; set; }
        public string name{ get; set; }
        public string docType{ get; set; }
        public bool isDirectory{ get; set; }
        public long size{ get; set; }
    }
}