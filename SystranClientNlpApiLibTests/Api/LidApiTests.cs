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
    public class LidApiTests
    {

        private static ApiClient client;
        private static LidApi lidApi;

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
            lidApi = new LidApi(Configuration.apiClient);
        }

        [TestMethod()]
        public void GetBasePathTest()
        {
            Assert.IsInstanceOfType(lidApi.apiClient.basePath, typeof(string));
        }

        [TestMethod()]
        public void NlpLidDetectLanguageDocumentGetTest()
        {
            LidDocumentResponse lidDocumentResponse = lidApi.NlpLidDetectLanguageDocumentGet(null, "This is a test", null);
            Assert.IsNotNull(lidDocumentResponse);
        }

        [TestMethod()]
        public void NlpLidDetectLanguageDocumentGetAsyncTest()
        {
            LidDocumentResponse lidDocumentResponse = new LidDocumentResponse();
            Task.Run(async () =>
            {
               lidDocumentResponse = await lidApi.NlpLidDetectLanguageDocumentGetAsync(null, "This is a test", null);
            }).Wait();
            Assert.IsNotNull(lidDocumentResponse);
        }

        [TestMethod()]
        public void NlpLidDetectLanguageParagraphGetTest()
        {
          LidParagraphResponse lidParagraphResponse = lidApi.NlpLidDetectLanguageParagraphGet(null, "This is a test", null);
          Assert.IsNotNull(lidParagraphResponse);
        }

        [TestMethod()]
        public void NlpLidDetectLanguageParagraphGetAsyncTest()
        {
            LidParagraphResponse lidParagraphResponse = new LidParagraphResponse();
            Task.Run(async () =>
            {
               lidParagraphResponse = await lidApi.NlpLidDetectLanguageParagraphGetAsync("../../test.txt", null, null);
            }).Wait();
            Assert.IsNotNull(lidParagraphResponse);
        }
    }
}