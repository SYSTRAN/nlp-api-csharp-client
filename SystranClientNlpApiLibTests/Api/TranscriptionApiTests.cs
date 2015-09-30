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
    public class TranscriptionApiTests
    {
        private static ApiClient client;
        private static TranscriptionApi transcriptionApi;


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
            transcriptionApi = new TranscriptionApi(Configuration.apiClient);
        }

        [TestMethod()]
        public void GetBasePathTest()
        {
            Assert.IsInstanceOfType(transcriptionApi.apiClient.basePath, typeof(string));
        }

        [TestMethod()]
        public void NlpTranscriptionSupportedLanguagesGetTest()
        {
            TranscriptionSupportedLanguagesResponse transcriptionSupportedLanguagesResponse = new TranscriptionSupportedLanguagesResponse();
            transcriptionSupportedLanguagesResponse = transcriptionApi.NlpTranscriptionSupportedLanguagesGet(null, null, null);
            Assert.IsNotNull(transcriptionSupportedLanguagesResponse.LanguagePairs);
        }

        [TestMethod()]
        public void NlpTranscriptionSupportedLanguagesGetAsyncTest()
        {
            TranscriptionSupportedLanguagesResponse transcriptionSupportedLanguagesResponse = new TranscriptionSupportedLanguagesResponse();
            Task.Run(async () =>
            {
                transcriptionSupportedLanguagesResponse = await transcriptionApi.NlpTranscriptionSupportedLanguagesGetAsync(null, null, null);
            }).Wait();
            Assert.IsNotNull(transcriptionSupportedLanguagesResponse.LanguagePairs);

        }

        [TestMethod()]
        public void NlpTranscriptionTranscribeGetTest()
        {
            Assert.IsNotNull(transcriptionApi.NlpTranscriptionTranscribeGet(null, "this is a test", "en", "ru", null, null));
        }

        [TestMethod()]

        public void NlpTranscriptionTranscribeGetAsyncTest()
        {
            Task.Run(async () =>
            {
                Assert.IsNotNull(await transcriptionApi.NlpTranscriptionTranscribeGetAsync(null, "this is a test", "en", "ru", null, null));

            }).Wait();
        }
    }
}
    
