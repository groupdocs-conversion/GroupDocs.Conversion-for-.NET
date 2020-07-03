---
id: how-to-use-custom-cache-implementation
url: conversion/net/how-to-use-custom-cache-implementation
title: How to use custom cache implementation
weight: 1
description: "Follow this guide and learn how to implement custom cache implementation when document with GroupDocs.Conversion for .NET API."
keywords: Custom cache for GroupDocs.Conversion 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
**[GroupDocs.Conversion](https://products.groupdocs.com/conversion/net)** implements caching to local drive out of the box. For flexibility GroupDocs.Conversion provides and extension point which allows you to cache conversion result in your own way. You can do this by using [ICache](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.caching/icache) interface implementation.  
Let's see how to implement some custom cache implementation using this extension point.

## Using Redis cache

The following steps should be followed.

*   Create *RedisCache* class which implements [ICache](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.caching/icache) interface
*   Instantiate the *RedisCache* class
*   Declare a delegate which will be used from [Converter](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/converter) classas factory of [ConverterSettings](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/convertersettings). In the body of this delegate, instantiate [ConverterSettings](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/convertersettings) class and set property [Cache](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/convertersettings/properties/cache) with the *RedisCache* class instance from previous step
*   Instantiate [Converter](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/converter) class with path to source document and the delegate from the previous step as constructor's parameters
*   Create instance of [PdfConvertOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfconvertoptions) class
*   Call [Convert](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/converter/methods/convert/2) method of [Converter](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/converter) instance

Below is the code that demonstrates how to use custom caching for GroupDocs.Conversion.

```csharp
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using GroupDocs.Conversion.Caching;
using GroupDocs.Conversion.Options.Convert;
using StackExchange.Redis;
namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage.Caching
{
    internal class HowToUseCustomCacheImplementation
    {
        /// <summary>
        /// This example demonstrates how to implement custom cache when rendering document.
        /// </summary>
        public static void Run()
        {
            string outputDirectory = Constants.GetOutputDirectoryPath();
            
            RedisCache cache = new RedisCache("sample_");
            Contracts.Func<ConverterSettings> settingsFactory = () => new ConverterSettings
            {
                Cache = cache
            };
            using (Converter converter = new Converter(Constants.SAMPLE_DOCX, settingsFactory))
            {
                PdfConvertOptions options = new PdfConvertOptions();
                Stopwatch stopWatch = Stopwatch.StartNew();
                converter.Convert("converted.pdf", options);
                stopWatch.Stop();
                Console.WriteLine("Time taken on first call to Convert method {0} (ms).", stopWatch.ElapsedMilliseconds);
                stopWatch.Restart();
                converter.Convert("converted-1.pdf", options);
                stopWatch.Stop();
                Console.WriteLine("Time taken on second call to Convert method {0} (ms).", stopWatch.ElapsedMilliseconds);
            }
            Console.WriteLine($"\nSource document rendered successfully.\nCheck output in {outputDirectory}.");
        }
    }
    public class RedisCache : ICache, IDisposable
    {
        private readonly string _cacheKeyPrefix;
        private readonly ConnectionMultiplexer _redis;
        private readonly IDatabase _db;
        private readonly string _host = "192.168.0.1:6379";
        public RedisCache(string cacheKeyPrefix)
        {
            _cacheKeyPrefix = cacheKeyPrefix;
            _redis = ConnectionMultiplexer.Connect(_host);
            _db = _redis.GetDatabase();
        }
        public void Set(string key, object data)
        {
            if (data == null)
                return;
            string prefixedKey = GetPrefixedKey(key);
            using (MemoryStream stream = GetStream(data))
            {
                _db.StringSet(prefixedKey, RedisValue.CreateFrom(stream));
            }
        }
        public bool TryGetValue(string key, out object value)
        {
            var prefixedKey = GetPrefixedKey(key);
            var redisValue = _db.StringGet(prefixedKey);
            if (redisValue.HasValue)
            {
                var data = Deserialize(redisValue);
                value = data;
                return true;
            }

            value = default;
            return false;
        }
        public IEnumerable<string> GetKeys(string filter)
        {
            return _redis.GetServer(_host).Keys(pattern: $"*{filter}*")
                .Select(x => x.ToString().Replace(_cacheKeyPrefix, string.Empty))
                .Where(x => x.StartsWith(filter, StringComparison.InvariantCultureIgnoreCase))
                .ToList();
        }
        private string GetPrefixedKey(string key)
            => $"{_cacheKeyPrefix}{key}";
        private object Deserialize(RedisValue redisValue)
        {
            object data;
            using (MemoryStream stream = new MemoryStream(redisValue))
            {
                BinaryFormatter formatter = new BinaryFormatter
                {
                    Binder = new IgnoreAssemblyVersionSerializationBinder()
                };
                try
                {
                    data = formatter.Deserialize(stream);
                }
                catch (SerializationException)
                {
                    data = null;
                }
            }
            return data;
        }
        private MemoryStream GetStream(object data)
        {
            MemoryStream result = new MemoryStream();
            if (data is Stream stream)
            {
                stream.Position = 0;
                stream.CopyTo(result);
            }
            else
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(result, data);
            }
            return result;
        }
        public void Dispose()
        {
            _redis.Dispose();
        }
        private class IgnoreAssemblyVersionSerializationBinder : SerializationBinder
        {
            public override Type BindToType(string assemblyName, string typeName)
            {
                string assembly = Assembly.GetExecutingAssembly().FullName;
                Type type = Type.GetType($"{typeName}, {assembly}");
                return type;
            }
        }
    }
}

```

## More resources

### GitHub Examples
You may easily run the code above and see the feature in action in our GitHub examples:
*   [GroupDocs.Conversion for .NET examples, plugins, and showcase](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-.NET)
*   [GroupDocs.Conversion for Java examples, plugins, and showcase](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-Java)
*   [Document Conversion for .NET MVC UI Example](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-.NET-MVC)
*   [Document Conversion for .NET App WebForms UI Modern Example](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-.NET-WebForms)
*   [Document Conversion for Java App Dropwizard UI Modern Example](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-Java-Dropwizard)
*   [Document Conversion for Java Spring UI Example](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-Java-Spring)

### Free Online Document Converter Apps
Along with full-featured .NET library we provide free Apps and free services for document conversion.
In order to see a full potential of GroupDocs.Conversion, you are welcome to convert DOC to PDF, DOC to XLSX, PDF to DOC, PDF to XLSX, PPT to DOC and more with **[Free Online Document Converter App](https://products.groupdocs.app/conversion)** or get a full advantage of **[Free Online Document Converter Suite](https://conholdate.app/features/document-converter-online)** with advanced conversion settings and many more enterprise built-in features.

**Please note** that more [premium features](https://conholdate.app/features), advanced options and enhanced document management experience is available for signed-in users at [conholdate.app](https://conholdate.app) for **FREE**.  
If you don't own an account yet, register it now for free! No credit card is required!
