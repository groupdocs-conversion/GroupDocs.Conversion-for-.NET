using NUnit.Framework;
using System.Web.Routing;
using MvcContrib.TestHelper;
using Huygens;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using GroupDocs.Conversion.MVC.Controllers;
using GroupDocs.Conversion.MVC.Products.Common.Entity.Web;

namespace GroupDocs.Conversion.MVC.Test
{
    [TestFixture]
    public static class ConversionControllerTest
    {       

        [SetUp]
        public static void TestInitialize()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        [TearDown]
        public static void TearDown()
        {
            RouteTable.Routes.Clear();
        }

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

        [Test]
        public static void ViewMapControllerTest()
        {
            "~/conversion".Route().ShouldMapTo<ConversionController>(x => x.Index());
        }

        [Test]
        public static void FileTreeStatusCodeTest()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "/../../../src";
            using (var server = new DirectServer(path))
            {

                PostedDataEntity requestData = new PostedDataEntity();
                requestData.path = "";

                var request = new SerialisableRequest
                {
                    Method = "POST",
                    RequestUri = "/loadFileTree",
                    Content = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(requestData)),
                    Headers = new Dictionary<string, string>{
                        { "Content-Type", "application/json"},
                        { "Content-Length", JsonConvert.SerializeObject(requestData).Length.ToString()}
                    }
                };

                var result = server.DirectCall(request);
                Assert.That(result.StatusCode, Is.EqualTo(200));
            }
        }        
    }
}
