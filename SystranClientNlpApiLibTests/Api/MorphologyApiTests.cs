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
    public class MorphologyApiTests
    {
        private static ApiClient client;
        private static MorphologyApi morphologyApi;

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
            morphologyApi = new MorphologyApi(Configuration.apiClient);
        }

        [TestMethod()]
        public void GetBasePathTest()
        {
           Assert.IsInstanceOfType(morphologyApi.apiClient.basePath, typeof(string));
        }

        [TestMethod()]
        public void NlpMorphologyExtractLemmaGetTest()
        {
          MorphologyExtractLemmaResponse morphologyExtractLemmaResponse =  morphologyApi.NlpMorphologyExtractLemmaGet("this is a test", null, "en", null, null);
            Assert.IsNotNull(morphologyExtractLemmaResponse.Lemmas);
        }

        [TestMethod()]
        public void NlpMorphologyExtractLemmaGetAsyncTest()
        {
            MorphologyExtractLemmaResponse morphologyExtractLemmaResponse = new MorphologyExtractLemmaResponse();
            Task.Run(async () =>
            {
                morphologyExtractLemmaResponse = await morphologyApi.NlpMorphologyExtractLemmaGetAsync("this is a test", null, "en", null, null);
            }).Wait();
            Assert.IsNotNull(morphologyExtractLemmaResponse.Lemmas);
        }

        [TestMethod()]
        public void NlpMorphologyExtractNpGetTest()
        {
           MorphologyExtractNPResponse morphologyExtractNPResponse = morphologyApi.NlpMorphologyExtractNpGet("This is a test", null, "en", null, null);
            Assert.IsNotNull(morphologyExtractNPResponse.Chunks);
        }

        [TestMethod()]
        public void NlpMorphologyExtractNpGetAsyncTest()
        {
            MorphologyExtractNPResponse morphologyExtractNPResponse = new MorphologyExtractNPResponse();
            Task.Run(async () =>
            {
                morphologyExtractNPResponse = await morphologyApi.NlpMorphologyExtractNpGetAsync("This is a test", null, "en", null, null);
            }).Wait();
            Assert.IsNotNull(morphologyExtractNPResponse.Chunks);
        }

        [TestMethod()]
        public void NlpMorphologyExtractPosGetTest()
        {

          MorphologyExtractPosResponse morphologyExtractPosResponse =  morphologyApi.NlpMorphologyExtractPosGet("this is a test", null, "en", null, null);
          Assert.IsNotNull(morphologyExtractPosResponse);
                }

        [TestMethod()]
        public void NlpMorphologyExtractPosGetAsyncTest()
        {
            MorphologyExtractPosResponse morphologyExtractPosResponse = new MorphologyExtractPosResponse();
            Task.Run(async () =>
            {
                morphologyExtractPosResponse = await morphologyApi.NlpMorphologyExtractPosGetAsync("this is a test", null, "en", null, null);
            }).Wait();
            Assert.IsNotNull(morphologyExtractPosResponse);
        }

        [TestMethod()]
        public void NlpMorphologySupportedLanguagesGetTest()
        {
         SupportedLanguagesResponse supportedLanguagesResponse = morphologyApi.NlpMorphologySupportedLanguagesGet(null);
         Assert.IsNotNull(supportedLanguagesResponse.Languages);
        }

        [TestMethod()]
        public void NlpMorphologySupportedLanguagesGetAsyncTest()
        {
            SupportedLanguagesResponse supportedLanguagesResponse = new SupportedLanguagesResponse();
            Task.Run(async () =>
            {
                 supportedLanguagesResponse = await morphologyApi.NlpMorphologySupportedLanguagesGetAsync(null);
            }).Wait();
            Assert.IsNotNull(supportedLanguagesResponse.Languages);

        }
    }
}