using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using Systran.NlpClientLib.Client;
using Systran.NlpClientLib.Model;

namespace Systran.NlpClientLib.Api {
  

  public interface ITranscriptionApi {
    
    /// <summary>
    /// Supported Languages List of languages pairs in which Transcription is supported. This list can be limited to a specific source language or target language.
    /// </summary>
    /// <param name="Source">Source Language code ([details](#description_langage_code_values))</param>/// <param name="Target">Target Language code ([details](#description_langage_code_values))</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>TranscriptionSupportedLanguagesResponse</returns>
    TranscriptionSupportedLanguagesResponse NlpTranscriptionSupportedLanguagesGet (string Source, string Target, string Callback);

    /// <summary>
    /// Supported Languages List of languages pairs in which Transcription is supported. This list can be limited to a specific source language or target language.
    /// </summary>
    /// <param name="Source">Source Language code ([details](#description_langage_code_values))</param>/// <param name="Target">Target Language code ([details](#description_langage_code_values))</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>TranscriptionSupportedLanguagesResponse</returns>
    Task<TranscriptionSupportedLanguagesResponse> NlpTranscriptionSupportedLanguagesGetAsync (string Source, string Target, string Callback);
    
    /// <summary>
    /// Transcribe Transcribe text from a source language to a target language.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Source">Source Language code ([details](#description_langage_code_values))</param>/// <param name="Target">Target Language code ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>string</returns>
    string NlpTranscriptionTranscribeGet (string InputFile, string Input, string Source, string Target, int? Profile, string Callback);

    /// <summary>
    /// Transcribe Transcribe text from a source language to a target language.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Source">Source Language code ([details](#description_langage_code_values))</param>/// <param name="Target">Target Language code ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>string</returns>
    Task<string> NlpTranscriptionTranscribeGetAsync (string InputFile, string Input, string Source, string Target, int? Profile, string Callback);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class TranscriptionApi : ITranscriptionApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="TranscriptionApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public TranscriptionApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TranscriptionApi"/> class.
    /// </summary>
    /// <returns></returns>
    public TranscriptionApi(String basePath)
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
    /// Supported Languages List of languages pairs in which Transcription is supported. This list can be limited to a specific source language or target language.
    /// </summary>
    /// <param name="Source">Source Language code ([details](#description_langage_code_values))</param>/// <param name="Target">Target Language code ([details](#description_langage_code_values))</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>TranscriptionSupportedLanguagesResponse</returns>
    public TranscriptionSupportedLanguagesResponse NlpTranscriptionSupportedLanguagesGet (string Source, string Target, string Callback) {

      

      var path = "/nlp/transcription/supportedLanguages";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Source != null) queryParams.Add("source", apiClient.ParameterToString(Source)); // query parameter
       if (Target != null) queryParams.Add("target", apiClient.ParameterToString(Target)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling NlpTranscriptionSupportedLanguagesGet: " + response.Content, response.Content);
      }
      return (TranscriptionSupportedLanguagesResponse) apiClient.Deserialize(response.Content, typeof(TranscriptionSupportedLanguagesResponse));
    }
	
	 /// <summary>
    /// Supported Languages List of languages pairs in which Transcription is supported. This list can be limited to a specific source language or target language.
    /// </summary>
    /// <param name="Source">Source Language code ([details](#description_langage_code_values))</param>/// <param name="Target">Target Language code ([details](#description_langage_code_values))</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>TranscriptionSupportedLanguagesResponse</returns>
    public async Task<TranscriptionSupportedLanguagesResponse> NlpTranscriptionSupportedLanguagesGetAsync (string Source, string Target, string Callback) {

      

      var path = "/nlp/transcription/supportedLanguages";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Source != null) queryParams.Add("source", apiClient.ParameterToString(Source)); // query parameter
       if (Target != null) queryParams.Add("target", apiClient.ParameterToString(Target)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling NlpTranscriptionSupportedLanguagesGet: " + response.Content, response.Content);
      }
      return (TranscriptionSupportedLanguagesResponse) apiClient.Deserialize(response.Content, typeof(TranscriptionSupportedLanguagesResponse));
    }
    
    /// <summary>
    /// Transcribe Transcribe text from a source language to a target language.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Source">Source Language code ([details](#description_langage_code_values))</param>/// <param name="Target">Target Language code ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>string</returns>
    public string NlpTranscriptionTranscribeGet (string InputFile, string Input, string Source, string Target, int? Profile, string Callback) {

      
      // verify the required parameter 'Source' is set
      if (Source == null) throw new ApiException(400, "Missing required parameter 'Source' when calling NlpTranscriptionTranscribeGet");
      
      // verify the required parameter 'Target' is set
      if (Target == null) throw new ApiException(400, "Missing required parameter 'Target' when calling NlpTranscriptionTranscribeGet");
      

      var path = "/nlp/transcription/transcribe";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Input != null) queryParams.Add("input", apiClient.ParameterToString(Input)); // query parameter
       if (Source != null) queryParams.Add("source", apiClient.ParameterToString(Source)); // query parameter
       if (Target != null) queryParams.Add("target", apiClient.ParameterToString(Target)); // query parameter
       if (Profile != null) queryParams.Add("profile", apiClient.ParameterToString(Profile)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      if (InputFile != null) fileParams.Add("inputFile", InputFile);
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling NlpTranscriptionTranscribeGet: " + response.Content, response.Content);
      }
      return (string) apiClient.Deserialize(response.Content, typeof(string));
    }
	
	 /// <summary>
    /// Transcribe Transcribe text from a source language to a target language.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Source">Source Language code ([details](#description_langage_code_values))</param>/// <param name="Target">Target Language code ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>string</returns>
    public async Task<string> NlpTranscriptionTranscribeGetAsync (string InputFile, string Input, string Source, string Target, int? Profile, string Callback) {

      
          // verify the required parameter 'Source' is set
          if (Source == null) throw new ApiException(400, "Missing required parameter 'Source' when calling NlpTranscriptionTranscribeGet");
      
          // verify the required parameter 'Target' is set
          if (Target == null) throw new ApiException(400, "Missing required parameter 'Target' when calling NlpTranscriptionTranscribeGet");
      

      var path = "/nlp/transcription/transcribe";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Input != null) queryParams.Add("input", apiClient.ParameterToString(Input)); // query parameter
       if (Source != null) queryParams.Add("source", apiClient.ParameterToString(Source)); // query parameter
       if (Target != null) queryParams.Add("target", apiClient.ParameterToString(Target)); // query parameter
       if (Profile != null) queryParams.Add("profile", apiClient.ParameterToString(Profile)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      if (InputFile != null) fileParams.Add("inputFile", InputFile);
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling NlpTranscriptionTranscribeGet: " + response.Content, response.Content);
      }
      return (string) apiClient.Deserialize(response.Content, typeof(string));
    }
    
  }  
  
}
