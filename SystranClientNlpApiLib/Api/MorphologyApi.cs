using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using Systran.NlpClientLib.Client;
using Systran.NlpClientLib.Model;

namespace Systran.NlpClientLib.Api {
  

  public interface IMorphologyApi {
    
    /// <summary>
    /// Get lemma Get the lemma for elements of an input text.\n
    /// </summary>
    /// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>MorphologyExtractLemmaResponse</returns>
    MorphologyExtractLemmaResponse NlpMorphologyExtractLemmaGet (string Input, string InputFile, string Lang, int? Profile, string Callback);

    /// <summary>
    /// Get lemma Get the lemma for elements of an input text.\n
    /// </summary>
    /// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>MorphologyExtractLemmaResponse</returns>
    Task<MorphologyExtractLemmaResponse> NlpMorphologyExtractLemmaGetAsync (string Input, string InputFile, string Lang, int? Profile, string Callback);
    
    /// <summary>
    /// Get NP/chunks Get Noun-phrases and chunks from an input text.\n
    /// </summary>
    /// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>MorphologyExtractNPResponse</returns>
    MorphologyExtractNPResponse NlpMorphologyExtractNpGet (string Input, string InputFile, string Lang, int? Profile, string Callback);

    /// <summary>
    /// Get NP/chunks Get Noun-phrases and chunks from an input text.\n
    /// </summary>
    /// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>MorphologyExtractNPResponse</returns>
    Task<MorphologyExtractNPResponse> NlpMorphologyExtractNpGetAsync (string Input, string InputFile, string Lang, int? Profile, string Callback);
    
    /// <summary>
    /// Get part of speech Get the part of speech for elements of an input text.\n
    /// </summary>
    /// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>MorphologyExtractPosResponse</returns>
    MorphologyExtractPosResponse NlpMorphologyExtractPosGet (string Input, string InputFile, string Lang, int? Profile, string Callback);

    /// <summary>
    /// Get part of speech Get the part of speech for elements of an input text.\n
    /// </summary>
    /// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>MorphologyExtractPosResponse</returns>
    Task<MorphologyExtractPosResponse> NlpMorphologyExtractPosGetAsync (string Input, string InputFile, string Lang, int? Profile, string Callback);
    
    /// <summary>
    /// Supported Languages List of languages pairs in which Morphological analysis is supported.
    /// </summary>
    /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SupportedLanguagesResponse</returns>
    SupportedLanguagesResponse NlpMorphologySupportedLanguagesGet (string Callback);

    /// <summary>
    /// Supported Languages List of languages pairs in which Morphological analysis is supported.
    /// </summary>
    /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SupportedLanguagesResponse</returns>
    Task<SupportedLanguagesResponse> NlpMorphologySupportedLanguagesGetAsync (string Callback);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class MorphologyApi : IMorphologyApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="MorphologyApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public MorphologyApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MorphologyApi"/> class.
    /// </summary>
    /// <returns></returns>
    public MorphologyApi(String basePath)
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
    /// Get lemma Get the lemma for elements of an input text.\n
    /// </summary>
    /// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>MorphologyExtractLemmaResponse</returns>
    public MorphologyExtractLemmaResponse NlpMorphologyExtractLemmaGet (string Input, string InputFile, string Lang, int? Profile, string Callback) {

      
      // verify the required parameter 'Lang' is set
      if (Lang == null) throw new ApiException(400, "Missing required parameter 'Lang' when calling NlpMorphologyExtractLemmaGet");
      

      var path = "/nlp/morphology/extract/lemma";
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
        throw new ApiException ((int)response.StatusCode, "Error calling NlpMorphologyExtractLemmaGet: " + response.Content, response.Content);
      }
      return (MorphologyExtractLemmaResponse) apiClient.Deserialize(response.Content, typeof(MorphologyExtractLemmaResponse));
    }
	
	 /// <summary>
    /// Get lemma Get the lemma for elements of an input text.\n
    /// </summary>
    /// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>MorphologyExtractLemmaResponse</returns>
    public async Task<MorphologyExtractLemmaResponse> NlpMorphologyExtractLemmaGetAsync (string Input, string InputFile, string Lang, int? Profile, string Callback) {

      
          // verify the required parameter 'Lang' is set
          if (Lang == null) throw new ApiException(400, "Missing required parameter 'Lang' when calling NlpMorphologyExtractLemmaGet");
      

      var path = "/nlp/morphology/extract/lemma";
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
        throw new ApiException ((int)response.StatusCode, "Error calling NlpMorphologyExtractLemmaGet: " + response.Content, response.Content);
      }
      return (MorphologyExtractLemmaResponse) apiClient.Deserialize(response.Content, typeof(MorphologyExtractLemmaResponse));
    }
    
    /// <summary>
    /// Get NP/chunks Get Noun-phrases and chunks from an input text.\n
    /// </summary>
    /// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>MorphologyExtractNPResponse</returns>
    public MorphologyExtractNPResponse NlpMorphologyExtractNpGet (string Input, string InputFile, string Lang, int? Profile, string Callback) {

      
      // verify the required parameter 'Lang' is set
      if (Lang == null) throw new ApiException(400, "Missing required parameter 'Lang' when calling NlpMorphologyExtractNpGet");
      

      var path = "/nlp/morphology/extract/np";
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
        throw new ApiException ((int)response.StatusCode, "Error calling NlpMorphologyExtractNpGet: " + response.Content, response.Content);
      }
      return (MorphologyExtractNPResponse) apiClient.Deserialize(response.Content, typeof(MorphologyExtractNPResponse));
    }
	
	 /// <summary>
    /// Get NP/chunks Get Noun-phrases and chunks from an input text.\n
    /// </summary>
    /// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>MorphologyExtractNPResponse</returns>
    public async Task<MorphologyExtractNPResponse> NlpMorphologyExtractNpGetAsync (string Input, string InputFile, string Lang, int? Profile, string Callback) {

      
          // verify the required parameter 'Lang' is set
          if (Lang == null) throw new ApiException(400, "Missing required parameter 'Lang' when calling NlpMorphologyExtractNpGet");
      

      var path = "/nlp/morphology/extract/np";
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
        throw new ApiException ((int)response.StatusCode, "Error calling NlpMorphologyExtractNpGet: " + response.Content, response.Content);
      }
      return (MorphologyExtractNPResponse) apiClient.Deserialize(response.Content, typeof(MorphologyExtractNPResponse));
    }
    
    /// <summary>
    /// Get part of speech Get the part of speech for elements of an input text.\n
    /// </summary>
    /// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>MorphologyExtractPosResponse</returns>
    public MorphologyExtractPosResponse NlpMorphologyExtractPosGet (string Input, string InputFile, string Lang, int? Profile, string Callback) {

      
      // verify the required parameter 'Lang' is set
      if (Lang == null) throw new ApiException(400, "Missing required parameter 'Lang' when calling NlpMorphologyExtractPosGet");
      

      var path = "/nlp/morphology/extract/pos";
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
        throw new ApiException ((int)response.StatusCode, "Error calling NlpMorphologyExtractPosGet: " + response.Content, response.Content);
      }
      return (MorphologyExtractPosResponse) apiClient.Deserialize(response.Content, typeof(MorphologyExtractPosResponse));
    }
	
	 /// <summary>
    /// Get part of speech Get the part of speech for elements of an input text.\n
    /// </summary>
    /// <param name="Input">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="InputFile">input text\n\n**Either `input` or `inputFile` is required**\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>MorphologyExtractPosResponse</returns>
    public async Task<MorphologyExtractPosResponse> NlpMorphologyExtractPosGetAsync (string Input, string InputFile, string Lang, int? Profile, string Callback) {

      
          // verify the required parameter 'Lang' is set
          if (Lang == null) throw new ApiException(400, "Missing required parameter 'Lang' when calling NlpMorphologyExtractPosGet");
      

      var path = "/nlp/morphology/extract/pos";
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
        throw new ApiException ((int)response.StatusCode, "Error calling NlpMorphologyExtractPosGet: " + response.Content, response.Content);
      }
      return (MorphologyExtractPosResponse) apiClient.Deserialize(response.Content, typeof(MorphologyExtractPosResponse));
    }
    
    /// <summary>
    /// Supported Languages List of languages pairs in which Morphological analysis is supported.
    /// </summary>
    /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SupportedLanguagesResponse</returns>
    public SupportedLanguagesResponse NlpMorphologySupportedLanguagesGet (string Callback) {

      

      var path = "/nlp/morphology/supportedLanguages";
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
        throw new ApiException ((int)response.StatusCode, "Error calling NlpMorphologySupportedLanguagesGet: " + response.Content, response.Content);
      }
      return (SupportedLanguagesResponse) apiClient.Deserialize(response.Content, typeof(SupportedLanguagesResponse));
    }
	
	 /// <summary>
    /// Supported Languages List of languages pairs in which Morphological analysis is supported.
    /// </summary>
    /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SupportedLanguagesResponse</returns>
    public async Task<SupportedLanguagesResponse> NlpMorphologySupportedLanguagesGetAsync (string Callback) {

      

      var path = "/nlp/morphology/supportedLanguages";
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
        throw new ApiException ((int)response.StatusCode, "Error calling NlpMorphologySupportedLanguagesGet: " + response.Content, response.Content);
      }
      return (SupportedLanguagesResponse) apiClient.Deserialize(response.Content, typeof(SupportedLanguagesResponse));
    }
    
  }  
  
}
