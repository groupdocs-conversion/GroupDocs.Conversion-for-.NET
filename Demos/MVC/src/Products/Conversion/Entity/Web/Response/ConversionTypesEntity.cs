using GroupDocs.Conversion.MVC.Products.Common.Entity.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupDocs.Conversion.MVC.Products.Conversion.Entity.Web.Response
{
    public class ConversionTypesEntity : FileDescriptionEntity
    {        
        public List<string> conversionTypes { get; set; } 
    }
}