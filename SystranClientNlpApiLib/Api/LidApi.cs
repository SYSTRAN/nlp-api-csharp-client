using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using Systran.NlpClientLib.Client;
using Systran.NlpClientLib.Model;

namespace Systran.NlpClientLib.Api {
  

  public interface ILidApi {
    
    /// <summary>
    /// Document language detection\n Global language detection on document.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>LidDocumentResponse</returns>
    LidDocumentResponse NlpLidDetectLanguageDocumentGet (string InputFile, string Input, string Callback);

    /// <summary>
    /// Document language detection\n Global language detection on document.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>LidDocumentResponse</returns>
    Task<LidDocumentResponse> NlpLidDetectLanguageDocumentGetAsync (string InputFile, string Input, string Callback);
    
    /// <summary>
    /// Paragraph language detection\n Language detection for each paragraph in a document.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>LidParagraphResponse</returns>
    LidParagraphResponse NlpLidDetectLanguageParagraphGet (string InputFile, string Input, string Callback);

    /// <summary>
    /// Paragraph language detection\n Language detection for each paragraph in a document.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>LidParagraphResponse</returns>
    Task<LidParagraphResponse> NlpLidDetectLanguageParagraphGetAsync (string InputFile, string Input, string Callback);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class LidApi : ILidApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="LidApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public LidApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="LidApi"/> class.
    /// </summary>
    /// <returns></returns>
    public LidApi(String basePath)
    {
      this.apiClient = new ApiClient(basePath);
    }

    /// <summary>
    /// Sets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public void SetBasePath(String basePath) {
      this.apiClient.basePath = basePath;
    }

    /// <summary>
    /// Gets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public String GetBasePath(String basePath) {
      return this.apiClient.basePath;
    }

    /// <summary>
    /// Gets or sets the API client.
    /// </summary>
    /// <value>The API client</value>
    public ApiClient apiClient {get; set;}


    
    /// <summary>
    /// Document language detection\n Global language detection on document.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>LidDocumentResponse</returns>
    public LidDocumentResponse NlpLidDetectLanguageDocumentGet (string InputFile, string Input, string Callback) {

      

      var path = "/nlp/lid/detectLanguage/document";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Input != null) queryParams.Add("input", apiClient.ParameterToString(Input)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      if (InputFile != null) fileParams.Add("inputFile", InputFile);
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling NlpLidDetectLanguageDocumentGet: " + response.Content, response.Content);
      }
      return (LidDocumentResponse) apiClient.Deserialize(response.Content, typeof(LidDocumentResponse));
    }
	
	 /// <summary>
    /// Document language detection\n Global language detection on document.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>LidDocumentResponse</returns>
    public async Task<LidDocumentResponse> NlpLidDetectLanguageDocumentGetAsync (string InputFile, string Input, string Callback) {

      

      var path = "/nlp/lid/detectLanguage/document";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Input != null) queryParams.Add("input", apiClient.ParameterToString(Input)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      if (InputFile != null) fileParams.Add("inputFile", InputFile);
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling NlpLidDetectLanguageDocumentGet: " + response.Content, response.Content);
      }
      return (LidDocumentResponse) apiClient.Deserialize(response.Content, typeof(LidDocumentResponse));
    }
    
    /// <summary>
    /// Paragraph language detection\n Language detection for each paragraph in a document.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>LidParagraphResponse</returns>
    public LidParagraphResponse NlpLidDetectLanguageParagraphGet (string InputFile, string Input, string Callback) {

      

      var path = "/nlp/lid/detectLanguage/paragraph";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Input != null) queryParams.Add("input", apiClient.ParameterToString(Input)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      if (InputFile != null) fileParams.Add("inputFile", InputFile);
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling NlpLidDetectLanguageParagraphGet: " + response.Content, response.Content);
      }
      return (LidParagraphResponse) apiClient.Deserialize(response.Content, typeof(LidParagraphResponse));
    }
	
	 /// <summary>
    /// Paragraph language detection\n Language detection for each paragraph in a document.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>LidParagraphResponse</returns>
    public async Task<LidParagraphResponse> NlpLidDetectLanguageParagraphGetAsync (string InputFile, string Input, string Callback) {

      

      var path = "/nlp/lid/detectLanguage/paragraph";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Input != null) queryParams.Add("input", apiClient.ParameterToString(Input)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      if (InputFile != null) fileParams.Add("inputFile", InputFile);
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling NlpLidDetectLanguageParagraphGet: " + response.Content, response.Content);
      }
      return (LidParagraphResponse) apiClient.Deserialize(response.Content, typeof(LidParagraphResponse));
    }
    
  }  
  
}
