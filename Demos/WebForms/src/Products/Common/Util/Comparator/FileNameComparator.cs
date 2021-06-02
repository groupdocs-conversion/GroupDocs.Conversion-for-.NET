using System.Collections.Generic;
using System.IO;

namespace GroupDocs.Conversion.WebForms.Products.Common.Util.Comparator
{
    /// <summary>
    /// FileNameComparator
    /// </summary>
    public class FileNameComparator : IComparer<string>
    {
        /// <summary>
        /// Compare file names
        /// </summary>
        /// <param name="x">string</param>
        /// <param name="y">string</param>
        /// <returns></returns>
        public int Compare(string x, string y)
        {
            string strExt1 = Path.GetFileName(x);
            string strExt2 = Path.GetFileName(y);

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