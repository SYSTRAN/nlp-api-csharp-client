using Microsoft.VisualStudio.TestTools.UnitTesting;
using Systran.NlpClientLib.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systran.NlpClientLib.Client;
using Systran.NlpClientLib.Model;
using System.IO;

namespace Systran.NlpClientLib.Api.Tests
{
    [TestClass()]
    public class SegmentationApiTests
    {
        private static ApiClient client;
        private static SegmentationApi segmentationApi;

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            client = new ApiClient("https://platform.systran.net:8904");
            Configuration.apiClient = client;
            Dictionary<String, String> keys = new Dictionary<String, String>();
            string key;
            using (StreamReader streamReader = new StreamReader("../../apiKey.txt", Encoding.UTF8))
            {
                key = streamReader.ReadToEnd();
            }
            keys.Add("key", key); Configuration.apiKey = keys;
            segmentationApi = new SegmentationApi(Configuration.apiClient);
        }

        [TestMethod()]
        public void GetBasePathTest()
        {
            Assert.IsInstanceOfType(segmentationApi.apiClient.basePath, typeof(string));
        }

        [TestMethod()]
        public void NlpSegmentationSegmentGetTest()
        {
            SegmentationSegmentResponse segmentationSegmentResponse = new SegmentationSegmentResponse();
            segmentationSegmentResponse = segmentationApi.NlpSegmentationSegmentGet(null, "this is a test", "en", null, null);
            Assert.IsNotNull(segmentationSegmentResponse.Segments);
        }

        [TestMethod()]
        public void NlpSegmentationSegmentGetAsyncTest()
        {
            SegmentationSegmentResponse segmentationSegmentResponse = new SegmentationSegmentResponse();
            Task.Run(async () =>
            {
                segmentationSegmentResponse = await segmentationApi.NlpSegmentationSegmentGetAsync(null, "this is a test", "en", null, null);
            }).Wait();
            Assert.IsNotNull(segmentationSegmentResponse.Segments);
        }

        [TestMethod()]
        public void NlpSegmentationSegmentAndTokenizeGetTest()
        {
            SegmentationSegmentAndTokenizeResponse segmentationSegmentAndTokenizeResponse = new SegmentationSegmentAndTokenizeResponse();
            segmentationSegmentAndTokenizeResponse = segmentationApi.NlpSegmentationSegmentAndTokenizeGet(null, "this is a test", "en", null, null);
            Assert.IsNotNull(segmentationSegmentAndTokenizeResponse.Segments);
        }

        [TestMethod()]
        public void NlpSegmentationSegmentAndTokenizeGetAsyncTest()
        {
            SegmentationSegmentAndTokenizeResponse segmentationSegmentAndTokenizeResponse = new SegmentationSegmentAndTokenizeResponse();
            Task.Run(async () =>
            {
                segmentationSegmentAndTokenizeResponse = await segmentationApi.NlpSegmentationSegmentAndTokenizeGetAsync(null, "this is a test", "en", null, null);
            }).Wait();
            Assert.IsNotNull(segmentationSegmentAndTokenizeResponse.Segments);
        }

        [TestMethod()]
        public void NlpSegmentationSupportedLanguagesGetTest()
        {
            SupportedLanguagesResponse supportedLanguagesResponse = new SupportedLanguagesResponse();
            supportedLanguagesResponse =  segmentationApi.NlpSegmentationSupportedLanguagesGet(null);
            Assert.IsNotNull(supportedLanguagesResponse.Languages);
        }

        [TestMethod()]
        public void NlpSegmentationSupportedLanguagesGetAsyncTest()
        {
            SupportedLanguagesResponse supportedLanguagesResponse = new SupportedLanguagesResponse();
            Task.Run(async () =>
            {
                supportedLanguagesResponse = await segmentationApi.NlpSegmentationSupportedLanguagesGetAsync(null);
            }).Wait();
            Assert.IsNotNull(supportedLanguagesResponse.Languages);
        }

        [TestMethod()]
        public void NlpSegmentationTokenizeGetTest()
        {
            SegmentationTokenizeResponse segmentationTokenizeResponse = new SegmentationTokenizeResponse();
            segmentationTokenizeResponse = segmentationApi.NlpSegmentationTokenizeGet(null, "this is a test", "en", null, null);
            Assert.IsNotNull(segmentationTokenizeResponse.Tokens);
        }

        [TestMethod()]
        public void NlpSegmentationTokenizeGetAsyncTest()
        {
            SegmentationTokenizeResponse segmentationTokenizeResponse = new SegmentationTokenizeResponse();
            Task.Run(async () =>
            {
                segmentationTokenizeResponse = await segmentationApi.NlpSegmentationTokenizeGetAsync(null, "this is a test", "en", null, null);
            }).Wait();
            Assert.IsNotNull(segmentationTokenizeResponse.Tokens);
        }
    }
}