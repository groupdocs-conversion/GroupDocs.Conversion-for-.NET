using Huygens;
using NUnit.Framework;
using System;

namespace GroupDocs.Conversion.WebForms.Test
{
    [TestFixture]
    public static class ConversionTest
    {
        [Test]
        public static void ViewStatusTest()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "/../../../src";
            using (var server = new DirectServer(path))
            {
                var request = new SerialisableRequest
                {
                    Method = "GET",
                    RequestUri = "/conversion",
                    Content = null
                };

                var result = server.DirectCall(request);
                Assert.That(result.StatusCode, Is.EqualTo(200));
            }
        }
    }
}
