using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using Systran.NlpClientLib.Client;
using Systran.NlpClientLib.Model;

namespace Systran.NlpClientLib.Api {
  

  public interface ISegmentationApi {
    
    /// <summary>
    /// Segment\n Segment an input text.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SegmentationSegmentResponse</returns>
    SegmentationSegmentResponse NlpSegmentationSegmentGet (string InputFile, string Input, string Lang, int? Profile, string Callback);

    /// <summary>
    /// Segment\n Segment an input text.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SegmentationSegmentResponse</returns>
    Task<SegmentationSegmentResponse> NlpSegmentationSegmentGetAsync (string InputFile, string Input, string Lang, int? Profile, string Callback);
    
    /// <summary>
    /// Segment and tokenize\n Segment an input text, then tokenize each segment.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SegmentationSegmentAndTokenizeResponse</returns>
    SegmentationSegmentAndTokenizeResponse NlpSegmentationSegmentAndTokenizeGet (string InputFile, string Input, string Lang, int? Profile, string Callback);

    /// <summary>
    /// Segment and tokenize\n Segment an input text, then tokenize each segment.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SegmentationSegmentAndTokenizeResponse</returns>
    Task<SegmentationSegmentAndTokenizeResponse> NlpSegmentationSegmentAndTokenizeGetAsync (string InputFile, string Input, string Lang, int? Profile, string Callback);
    
    /// <summary>
    /// Supported Languages List of languages in which Segmentation is supported.
    /// </summary>
    /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SupportedLanguagesResponse</returns>
    SupportedLanguagesResponse NlpSegmentationSupportedLanguagesGet (string Callback);

    /// <summary>
    /// Supported Languages List of languages in which Segmentation is supported.
    /// </summary>
    /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SupportedLanguagesResponse</returns>
    Task<SupportedLanguagesResponse> NlpSegmentationSupportedLanguagesGetAsync (string Callback);
    
    /// <summary>
    /// Tokenize\n Tokenize an input text.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SegmentationTokenizeResponse</returns>
    SegmentationTokenizeResponse NlpSegmentationTokenizeGet (string InputFile, string Input, string Lang, int? Profile, string Callback);

    /// <summary>
    /// Tokenize\n Tokenize an input text.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SegmentationTokenizeResponse</returns>
    Task<SegmentationTokenizeResponse> NlpSegmentationTokenizeGetAsync (string InputFile, string Input, string Lang, int? Profile, string Callback);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class SegmentationApi : ISegmentationApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="SegmentationApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public SegmentationApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SegmentationApi"/> class.
    /// </summary>
    /// <returns></returns>
    public SegmentationApi(String basePath)
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
    /// Segment\n Segment an input text.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SegmentationSegmentResponse</returns>
    public SegmentationSegmentResponse NlpSegmentationSegmentGet (string InputFile, string Input, string Lang, int? Profile, string Callback) {

      
      // verify the required parameter 'Lang' is set
      if (Lang == null) throw new ApiException(400, "Missing required parameter 'Lang' when calling NlpSegmentationSegmentGet");
      

      var path = "/nlp/segmentation/segment";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Input != null) queryParams.Add("input", apiClient.ParameterToString(Input)); // query parameter
       if (Lang != null) queryParams.Add("lang", apiClient.ParameterToString(Lang)); // query parameter
       if (Profile != null) queryParams.Add("profile", apiClient.ParameterToString(Profile)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      if (InputFile != null) fileParams.Add("inputFile", InputFile);
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling NlpSegmentationSegmentGet: " + response.Content, response.Content);
      }
      return (SegmentationSegmentResponse) apiClient.Deserialize(response.Content, typeof(SegmentationSegmentResponse));
    }
	
	 /// <summary>
    /// Segment\n Segment an input text.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SegmentationSegmentResponse</returns>
    public async Task<SegmentationSegmentResponse> NlpSegmentationSegmentGetAsync (string InputFile, string Input, string Lang, int? Profile, string Callback) {

      
          // verify the required parameter 'Lang' is set
          if (Lang == null) throw new ApiException(400, "Missing required parameter 'Lang' when calling NlpSegmentationSegmentGet");
      

      var path = "/nlp/segmentation/segment";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Input != null) queryParams.Add("input", apiClient.ParameterToString(Input)); // query parameter
       if (Lang != null) queryParams.Add("lang", apiClient.ParameterToString(Lang)); // query parameter
       if (Profile != null) queryParams.Add("profile", apiClient.ParameterToString(Profile)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      if (InputFile != null) fileParams.Add("inputFile", InputFile);
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling NlpSegmentationSegmentGet: " + response.Content, response.Content);
      }
      return (SegmentationSegmentResponse) apiClient.Deserialize(response.Content, typeof(SegmentationSegmentResponse));
    }
    
    /// <summary>
    /// Segment and tokenize\n Segment an input text, then tokenize each segment.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SegmentationSegmentAndTokenizeResponse</returns>
    public SegmentationSegmentAndTokenizeResponse NlpSegmentationSegmentAndTokenizeGet (string InputFile, string Input, string Lang, int? Profile, string Callback) {

      
      // verify the required parameter 'Lang' is set
      if (Lang == null) throw new ApiException(400, "Missing required parameter 'Lang' when calling NlpSegmentationSegmentAndTokenizeGet");
      

      var path = "/nlp/segmentation/segmentAndTokenize";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Input != null) queryParams.Add("input", apiClient.ParameterToString(Input)); // query parameter
       if (Lang != null) queryParams.Add("lang", apiClient.ParameterToString(Lang)); // query parameter
       if (Profile != null) queryParams.Add("profile", apiClient.ParameterToString(Profile)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      if (InputFile != null) fileParams.Add("inputFile", InputFile);
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling NlpSegmentationSegmentAndTokenizeGet: " + response.Content, response.Content);
      }
      return (SegmentationSegmentAndTokenizeResponse) apiClient.Deserialize(response.Content, typeof(SegmentationSegmentAndTokenizeResponse));
    }
	
	 /// <summary>
    /// Segment and tokenize\n Segment an input text, then tokenize each segment.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SegmentationSegmentAndTokenizeResponse</returns>
    public async Task<SegmentationSegmentAndTokenizeResponse> NlpSegmentationSegmentAndTokenizeGetAsync (string InputFile, string Input, string Lang, int? Profile, string Callback) {

      
          // verify the required parameter 'Lang' is set
          if (Lang == null) throw new ApiException(400, "Missing required parameter 'Lang' when calling NlpSegmentationSegmentAndTokenizeGet");
      

      var path = "/nlp/segmentation/segmentAndTokenize";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Input != null) queryParams.Add("input", apiClient.ParameterToString(Input)); // query parameter
       if (Lang != null) queryParams.Add("lang", apiClient.ParameterToString(Lang)); // query parameter
       if (Profile != null) queryParams.Add("profile", apiClient.ParameterToString(Profile)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      if (InputFile != null) fileParams.Add("inputFile", InputFile);
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling NlpSegmentationSegmentAndTokenizeGet: " + response.Content, response.Content);
      }
      return (SegmentationSegmentAndTokenizeResponse) apiClient.Deserialize(response.Content, typeof(SegmentationSegmentAndTokenizeResponse));
    }
    
    /// <summary>
    /// Supported Languages List of languages in which Segmentation is supported.
    /// </summary>
    /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SupportedLanguagesResponse</returns>
    public SupportedLanguagesResponse NlpSegmentationSupportedLanguagesGet (string Callback) {

      

      var path = "/nlp/segmentation/supportedLanguages";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling NlpSegmentationSupportedLanguagesGet: " + response.Content, response.Content);
      }
      return (SupportedLanguagesResponse) apiClient.Deserialize(response.Content, typeof(SupportedLanguagesResponse));
    }
	
	 /// <summary>
    /// Supported Languages List of languages in which Segmentation is supported.
    /// </summary>
    /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SupportedLanguagesResponse</returns>
    public async Task<SupportedLanguagesResponse> NlpSegmentationSupportedLanguagesGetAsync (string Callback) {

      

      var path = "/nlp/segmentation/supportedLanguages";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling NlpSegmentationSupportedLanguagesGet: " + response.Content, response.Content);
      }
      return (SupportedLanguagesResponse) apiClient.Deserialize(response.Content, typeof(SupportedLanguagesResponse));
    }
    
    /// <summary>
    /// Tokenize\n Tokenize an input text.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SegmentationTokenizeResponse</returns>
    public SegmentationTokenizeResponse NlpSegmentationTokenizeGet (string InputFile, string Input, string Lang, int? Profile, string Callback) {

      
      // verify the required parameter 'Lang' is set
      if (Lang == null) throw new ApiException(400, "Missing required parameter 'Lang' when calling NlpSegmentationTokenizeGet");
      

      var path = "/nlp/segmentation/tokenize";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Input != null) queryParams.Add("input", apiClient.ParameterToString(Input)); // query parameter
       if (Lang != null) queryParams.Add("lang", apiClient.ParameterToString(Lang)); // query parameter
       if (Profile != null) queryParams.Add("profile", apiClient.ParameterToString(Profile)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      if (InputFile != null) fileParams.Add("inputFile", InputFile);
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling NlpSegmentationTokenizeGet: " + response.Content, response.Content);
      }
      return (SegmentationTokenizeResponse) apiClient.Deserialize(response.Content, typeof(SegmentationTokenizeResponse));
    }
	
	 /// <summary>
    /// Tokenize\n Tokenize an input text.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SegmentationTokenizeResponse</returns>
    public async Task<SegmentationTokenizeResponse> NlpSegmentationTokenizeGetAsync (string InputFile, string Input, string Lang, int? Profile, string Callback) {

      
          // verify the required parameter 'Lang' is set
          if (Lang == null) throw new ApiException(400, "Missing required parameter 'Lang' when calling NlpSegmentationTokenizeGet");
      

      var path = "/nlp/segmentation/tokenize";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Input != null) queryParams.Add("input", apiClient.ParameterToString(Input)); // query parameter
       if (Lang != null) queryParams.Add("lang", apiClient.ParameterToString(Lang)); // query parameter
       if (Profile != null) queryParams.Add("profile", apiClient.ParameterToString(Profile)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      if (InputFile != null) fileParams.Add("inputFile", InputFile);
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling NlpSegmentationTokenizeGet: " + response.Content, response.Content);
      }
      return (SegmentationTokenizeResponse) apiClient.Deserialize(response.Content, typeof(SegmentationTokenizeResponse));
    }
    
  }  
  
}
