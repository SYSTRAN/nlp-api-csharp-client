using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using Systran.NlpClientLib.Client;
using Systran.NlpClientLib.Model;

namespace Systran.NlpClientLib.Api {
  

  public interface INerApi {
    
    /// <summary>
    /// Get entity annotations\n Get the list of entity annotations given an input text.\nAn entity annotation is an entity associated with its position in the text.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>NerExtractAnnotationsResponse</returns>
    NerExtractAnnotationsResponse NlpNerExtractAnnotationsGet (string InputFile, string Input, string Lang, int? Profile, string Callback);

    /// <summary>
    /// Get entity annotations\n Get the list of entity annotations given an input text.\nAn entity annotation is an entity associated with its position in the text.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>NerExtractAnnotationsResponse</returns>
    Task<NerExtractAnnotationsResponse> NlpNerExtractAnnotationsGetAsync (string InputFile, string Input, string Lang, int? Profile, string Callback);
    
    /// <summary>
    /// Get list of entities\n Get the list of different entities given an input text.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>NerExtractEntitiesResponse</returns>
    NerExtractEntitiesResponse NlpNerExtractEntitiesGet (string InputFile, string Input, string Lang, int? Profile, string Callback);

    /// <summary>
    /// Get list of entities\n Get the list of different entities given an input text.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>NerExtractEntitiesResponse</returns>
    Task<NerExtractEntitiesResponse> NlpNerExtractEntitiesGetAsync (string InputFile, string Input, string Lang, int? Profile, string Callback);
    
    /// <summary>
    /// Supported Languages List of languages in which NER is supported.
    /// </summary>
    /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SupportedLanguagesResponse</returns>
    SupportedLanguagesResponse NlpNerSupportedLanguagesGet (string Callback);

    /// <summary>
    /// Supported Languages List of languages in which NER is supported.
    /// </summary>
    /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SupportedLanguagesResponse</returns>
    Task<SupportedLanguagesResponse> NlpNerSupportedLanguagesGetAsync (string Callback);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class NerApi : INerApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="NerApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public NerApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="NerApi"/> class.
    /// </summary>
    /// <returns></returns>
    public NerApi(String basePath)
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
    /// Get entity annotations\n Get the list of entity annotations given an input text.\nAn entity annotation is an entity associated with its position in the text.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>NerExtractAnnotationsResponse</returns>
    public NerExtractAnnotationsResponse NlpNerExtractAnnotationsGet (string InputFile, string Input, string Lang, int? Profile, string Callback) {

      
      // verify the required parameter 'Lang' is set
      if (Lang == null) throw new ApiException(400, "Missing required parameter 'Lang' when calling NlpNerExtractAnnotationsGet");
      

      var path = "/nlp/ner/extract/annotations";
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
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling NlpNerExtractAnnotationsGet: " + response.Content, response.Content);
      }
      return (NerExtractAnnotationsResponse) apiClient.Deserialize(response.Content, typeof(NerExtractAnnotationsResponse));
    }
	
	 /// <summary>
    /// Get entity annotations\n Get the list of entity annotations given an input text.\nAn entity annotation is an entity associated with its position in the text.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>NerExtractAnnotationsResponse</returns>
    public async Task<NerExtractAnnotationsResponse> NlpNerExtractAnnotationsGetAsync (string InputFile, string Input, string Lang, int? Profile, string Callback) {

      
          // verify the required parameter 'Lang' is set
          if (Lang == null) throw new ApiException(400, "Missing required parameter 'Lang' when calling NlpNerExtractAnnotationsGet");
      

      var path = "/nlp/ner/extract/annotations";
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
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling NlpNerExtractAnnotationsGet: " + response.Content, response.Content);
      }
      return (NerExtractAnnotationsResponse) apiClient.Deserialize(response.Content, typeof(NerExtractAnnotationsResponse));
    }
    
    /// <summary>
    /// Get list of entities\n Get the list of different entities given an input text.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>NerExtractEntitiesResponse</returns>
    public NerExtractEntitiesResponse NlpNerExtractEntitiesGet (string InputFile, string Input, string Lang, int? Profile, string Callback) {

      
      // verify the required parameter 'Lang' is set
      if (Lang == null) throw new ApiException(400, "Missing required parameter 'Lang' when calling NlpNerExtractEntitiesGet");
      

      var path = "/nlp/ner/extract/entities";
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
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling NlpNerExtractEntitiesGet: " + response.Content, response.Content);
      }
      return (NerExtractEntitiesResponse) apiClient.Deserialize(response.Content, typeof(NerExtractEntitiesResponse));
    }
	
	 /// <summary>
    /// Get list of entities\n Get the list of different entities given an input text.\n
    /// </summary>
    /// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>NerExtractEntitiesResponse</returns>
    public async Task<NerExtractEntitiesResponse> NlpNerExtractEntitiesGetAsync (string InputFile, string Input, string Lang, int? Profile, string Callback) {

      
          // verify the required parameter 'Lang' is set
          if (Lang == null) throw new ApiException(400, "Missing required parameter 'Lang' when calling NlpNerExtractEntitiesGet");
      

      var path = "/nlp/ner/extract/entities";
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
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling NlpNerExtractEntitiesGet: " + response.Content, response.Content);
      }
      return (NerExtractEntitiesResponse) apiClient.Deserialize(response.Content, typeof(NerExtractEntitiesResponse));
    }
    
    /// <summary>
    /// Supported Languages List of languages in which NER is supported.
    /// </summary>
    /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SupportedLanguagesResponse</returns>
    public SupportedLanguagesResponse NlpNerSupportedLanguagesGet (string Callback) {

      

      var path = "/nlp/ner/supportedLanguages";
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
        throw new ApiException ((int)response.StatusCode, "Error calling NlpNerSupportedLanguagesGet: " + response.Content, response.Content);
      }
      return (SupportedLanguagesResponse) apiClient.Deserialize(response.Content, typeof(SupportedLanguagesResponse));
    }
	
	 /// <summary>
    /// Supported Languages List of languages in which NER is supported.
    /// </summary>
    /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SupportedLanguagesResponse</returns>
    public async Task<SupportedLanguagesResponse> NlpNerSupportedLanguagesGetAsync (string Callback) {

      

      var path = "/nlp/ner/supportedLanguages";
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
        throw new ApiException ((int)response.StatusCode, "Error calling NlpNerSupportedLanguagesGet: " + response.Content, response.Content);
      }
      return (SupportedLanguagesResponse) apiClient.Deserialize(response.Content, typeof(SupportedLanguagesResponse));
    }
    
  }  
  
}
