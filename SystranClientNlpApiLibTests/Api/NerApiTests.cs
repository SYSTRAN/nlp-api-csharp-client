using Microsoft.VisualStudio.TestTools.UnitTesting;
using Systran.NlpClientLib.Api;
using Systran.NlpClientLib.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systran.NlpClientLib.Client;
using System.IO;

namespace Systran.NlpClientLib.Api.Tests
{
    [TestClass()]
    public class NerApiTests
    {

        private static ApiClient client;
        private static NerApi nerApi;

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            client = new ApiClient("https://platform.systran.net:8904");
            Configuration.apiClient = client;
            if (!File.Exists("../../apiKey.txt"))
                throw new Exception("To properly run the tests, please add an apiKey.txt file containing your api key in the SystranClientMultimodalApiLibTests folder or edit the test file with your key");
            Dictionary<String, String> keys = new Dictionary<String, String>();
            string key;
            using (StreamReader streamReader = new StreamReader("../../apiKey.txt", Encoding.UTF8))
            {
                key = streamReader.ReadToEnd();
            }
            keys.Add("key", key);
            if (keys.Count == 0)
                throw new Exception("No api key found, please check your apiKey.txt file");
            Configuration.apiKey = keys;
            nerApi = new NerApi(Configuration.apiClient);
        }

        [TestMethod()]
        public void GetBasePathTest()
        {
            Assert.IsInstanceOfType(nerApi.apiClient.basePath, typeof(string));
        }

        [TestMethod()]
        public void NlpNerExtractAnnotationsGetTest()
        {
            NerExtractAnnotationsResponse nerExtractAnnotationsResponse = new NerExtractAnnotationsResponse();
            nerExtractAnnotationsResponse = nerApi.NlpNerExtractAnnotationsGet(null, "This is a test", "en", null, null);
            Assert.IsNotNull(nerExtractAnnotationsResponse.Annotations);
        }

        [TestMethod()]
        public void NlpNerExtractAnnotationsGetAsyncTest()
        {
            NerExtractAnnotationsResponse nerExtractAnnotationsResponse = new NerExtractAnnotationsResponse();
            Task.Run(async () =>
            {
                nerExtractAnnotationsResponse = await nerApi.NlpNerExtractAnnotationsGetAsync("../../test.txt", null, "en", null, null);
            }).Wait();
            Assert.IsNotNull(nerExtractAnnotationsResponse.Annotations);
        }

        [TestMethod()]
        public void NlpNerExtractEntitiesGetTest()
        {
            NerExtractEntitiesResponse nerExtractEntitiesResponse = new NerExtractEntitiesResponse();
            nerExtractEntitiesResponse = nerApi.NlpNerExtractEntitiesGet("test.txt", null, "en", null, null);
            Assert.IsNotNull(nerExtractEntitiesResponse.Entities);
        }

        [TestMethod()]
        public void NlpNerExtractEntitiesGetAsyncTest()
        {
            NerExtractEntitiesResponse nerExtractEntitiesResponse = new NerExtractEntitiesResponse();
            Task.Run(async () =>
            {
                nerExtractEntitiesResponse = await nerApi.NlpNerExtractEntitiesGetAsync(null, "This is a test", "en", null, null);
            }).Wait();
            Assert.IsNotNull(nerExtractEntitiesResponse.Entities);
        }

        [TestMethod()]
        public void NlpNerSupportedLanguagesGetTest()
        {
            SupportedLanguagesResponse supportedLanguagesResponse = new SupportedLanguagesResponse();
            supportedLanguagesResponse = nerApi.NlpNerSupportedLanguagesGet(null);
            Assert.IsNotNull(supportedLanguagesResponse.Languages);
        }

        [TestMethod()]
        public void NlpNerSupportedLanguagesGetAsyncTest()
        {
            SupportedLanguagesResponse supportedLanguagesResponse = new SupportedLanguagesResponse();
            Task.Run(async () =>
            {
                supportedLanguagesResponse = await nerApi.NlpNerSupportedLanguagesGetAsync(null);
            }).Wait();
            Assert.IsNotNull(supportedLanguagesResponse.Languages);
        }
    }
}