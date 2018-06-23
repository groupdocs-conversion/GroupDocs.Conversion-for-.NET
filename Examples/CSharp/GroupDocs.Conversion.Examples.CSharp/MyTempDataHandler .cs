using GroupDocs.Conversion.Config;
using GroupDocs.Conversion.Converter.Option;
using GroupDocs.Conversion.Handler;
using GroupDocs.Conversion.Handler.Temp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GroupDocs.Conversion.Examples.CSharp
{
    internal class MyTempDataHandler : ITempDataHandler
    {
        public Stream CreateTempStream()
        {
            return new FileStream(string.Format(@"c:\temp\gd-{0:N}.tmp", Guid.NewGuid()), FileMode.Create);
        } 
    }
}
