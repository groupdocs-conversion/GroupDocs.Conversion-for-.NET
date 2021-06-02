using GroupDocs.Conversion.MVC.Products.Conversion.Config;

namespace GroupDocs.Conversion.MVC.Products.Common.Config
{
    /// <summary>
    /// Global configuration
    /// </summary>
    public class GlobalConfiguration
    {
        private ServerConfiguration Server;
        private ApplicationConfiguration Application;
        private CommonConfiguration Common;
        private readonly ConversionConfiguration Conversion;
       
        /// <summary>
        /// Get all configurations
        /// </summary>
        public GlobalConfiguration()
        {            
            Server = new ServerConfiguration();
            Application = new ApplicationConfiguration();
            Common = new CommonConfiguration();
            Conversion = new ConversionConfiguration();
        }

        public ConversionConfiguration GetConversionConfiguration() {
            return Conversion;
        }

        public ServerConfiguration GetServerConfiguration()
        {
            return Server;
        }

        public ApplicationConfiguration GetApplicationConfiguration()
        {
            return Application;
        }

        public CommonConfiguration GetCommonConfiguration()
        {
            return Common;
        }
    }
}