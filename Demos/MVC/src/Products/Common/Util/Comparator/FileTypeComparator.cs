using System.Collections.Generic;
using System.IO;

namespace GroupDocs.Conversion.MVC.Products.Common.Util.Comparator
{
    /// <summary>
    /// FileTypeComparator
    /// </summary>
    public class FileTypeComparator : IComparer<string>
    {
        /// <summary>
        /// Compare file types
        /// </summary>
        /// <param name="x">string</param>
        /// <param name="y">string</param>
        /// <returns></returns>
        public int Compare(string x, string y)
        {
            string strExt1 = Path.GetExtension(x);
            string strExt2 = Path.GetExtension(y);

            if (strExt1.Equals(strExt2))
            {
                return x.CompareTo(y);
            }
            else
            {
                return strExt1.CompareTo(strExt2);
            }
        }
    }
}