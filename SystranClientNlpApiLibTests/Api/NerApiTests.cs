﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Systran.NlpClientLib.Api;
using Systran.NlpClientLib.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systran.NlpClientLib.Client;

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
            client = new ApiClient("https://platformapi-stag.systran.net:8904");
            Configuration.apiClient = client;
            Dictionary<String, String> keys = new Dictionary<String, String>();
            keys.Add("key", "a72c2f99-5841-4259-88a6-f75f9860f992");
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
            nerExtractAnnotationsResponse = nerApi.NlpNerExtractAnnotationsGet("this is a test", null, "en", null, null);
            Assert.IsNotNull(nerExtractAnnotationsResponse.Annotations);
        }

        [TestMethod()]
        public void NlpNerExtractAnnotationsGetAsyncTest()
        {
            NerExtractAnnotationsResponse nerExtractAnnotationsResponse = new NerExtractAnnotationsResponse();
            Task.Run(async () =>
            {
                nerExtractAnnotationsResponse = await nerApi.NlpNerExtractAnnotationsGetAsync("this is a test", null, "en", null, null);
            }).Wait();
            Assert.IsNotNull(nerExtractAnnotationsResponse.Annotations);
        }

        [TestMethod()]
        public void NlpNerExtractEntitiesGetTest()
        {
            NerExtractEntitiesResponse nerExtractEntitiesResponse = new NerExtractEntitiesResponse();
            nerExtractEntitiesResponse = nerApi.NlpNerExtractEntitiesGet("This is a test", null, "en", null, null);
            Assert.IsNotNull(nerExtractEntitiesResponse.Entities);
        }

        [TestMethod()]
        public void NlpNerExtractEntitiesGetAsyncTest()
        {
            NerExtractEntitiesResponse nerExtractEntitiesResponse = new NerExtractEntitiesResponse();
            Task.Run(async () =>
            {
                nerExtractEntitiesResponse = await nerApi.NlpNerExtractEntitiesGetAsync("This is a test", null, "en", null, null);
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