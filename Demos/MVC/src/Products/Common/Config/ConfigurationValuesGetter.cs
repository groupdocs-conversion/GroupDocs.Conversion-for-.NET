using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupDocs.Conversion.MVC.Products.Common.Config
{
    public class ConfigurationValuesGetter
    {
        private readonly dynamic Configuration;

        public ConfigurationValuesGetter(dynamic configuration)
        {
            Configuration = configuration;
        }

        public string GetStringPropertyValue(string propertyName)
        {
            return (Configuration != null && Configuration[propertyName] != null && !String.IsNullOrEmpty(Configuration[propertyName].ToString())) ?
                Configuration[propertyName].ToString() :
                null;
        }

        public string GetStringPropertyValue(string propertyName, string defaultValue)
        {
            return (Configuration != null && Configuration[propertyName] != null && !String.IsNullOrEmpty(Configuration[propertyName].ToString())) ?
                Configuration[propertyName].ToString() :
                defaultValue;
        }

        public int GetIntegerPropertyValue(string propertyName, int defaultValue)
        {
            int value;
            value = (Configuration != null && Configuration[propertyName] != null && !String.IsNullOrEmpty(Configuration[propertyName].ToString())) ?
                Convert.ToInt32(Configuration[propertyName]) :
                defaultValue;
            return value;
        }

        public int GetIntegerPropertyValue(string propertyName, int defaultValue, string innerPropertyName)
        {
            int value;
            if (!String.IsNullOrEmpty(innerPropertyName))
            {
                value = (Configuration != null && Configuration[propertyName] != null && !String.IsNullOrEmpty(Configuration[propertyName][innerPropertyName].ToString())) ?
                    Convert.ToInt32(Configuration[propertyName][innerPropertyName]) :
                    defaultValue;
            }
            else
            {
                value = (Configuration != null && Configuration[propertyName] != null && !String.IsNullOrEmpty(Configuration[propertyName].ToString())) ?
                    Convert.ToInt32(Configuration[propertyName]) :
                    defaultValue;
            }
            return value;
        }

        public bool GetBooleanPropertyValue(string propertyName, bool defaultValue)
        {
            return (Configuration != null && Configuration[propertyName] != null && !String.IsNullOrEmpty(Configuration[propertyName].ToString())) ? Convert.ToBoolean(Configuration[propertyName]) : defaultValue;
        }
    }
}