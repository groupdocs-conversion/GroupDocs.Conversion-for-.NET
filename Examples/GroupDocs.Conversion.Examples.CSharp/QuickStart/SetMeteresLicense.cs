using System;

namespace GroupDocs.Conversion.Examples.CSharp.QuickStart
{
    /// <summary>
    /// This example demonstrates how to set Metered license.
    /// Learn more about Metered license at https://purchase.groupdocs.com/faqs/licensing/metered.
    /// </summary>
    internal static class SetMeteredLicense
    {
        public static void Run()
        {
            string publicKey = "*****";
            string privateKey = "*****";

            Metered metered = new Metered();
            metered.SetMeteredKey(publicKey, privateKey);

            Console.WriteLine("License set successfully.");
        }
    }
}
