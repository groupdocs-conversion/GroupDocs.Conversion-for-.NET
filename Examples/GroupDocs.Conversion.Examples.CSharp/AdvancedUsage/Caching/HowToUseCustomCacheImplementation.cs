#if !NETCOREAPP   

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

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
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

            using (Converter converter = new Converter(Constants.SAMPLE_PDF, settingsFactory))
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
        // private readonly string _host = "192.168.0.1:6379";
        private readonly string _host = "192.168.222.4:6379";

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
            using (MemoryStream stream = new MemoryStream())
            {
                ((Stream) data).CopyTo(stream);
                _db.StringSet(prefixedKey, RedisValue.CreateFrom(stream));
            }
        }

        public bool TryGetValue(string key, out object value)
        {
            var prefixedKey = GetPrefixedKey(key);
            var redisValue = _db.StringGet(prefixedKey);

            if (redisValue.HasValue)
            {
                value = new MemoryStream(redisValue);

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

        public void Dispose()
        {
            _redis.Dispose();
        }
    }
}

#endif