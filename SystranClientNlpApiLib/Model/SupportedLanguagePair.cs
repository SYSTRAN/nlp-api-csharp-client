using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.NlpClientLib.Model {

  /// <summary>
  /// Supported language pair
  /// </summary>
  [DataContract]
  public class SupportedLanguagePair {
    
    /* Source language code */
    [DataMember(Name="source", EmitDefaultValue=false)]
    public string Source { get; set; }

    
    /* Target language code */
    [DataMember(Name="target", EmitDefaultValue=false)]
    public string Target { get; set; }

    
    /* Array of profiles */
    [DataMember(Name="profiles", EmitDefaultValue=false)]
    public List<Profile> Profiles { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SupportedLanguagePair {\n");
      
      sb.Append("  Source: ").Append(Source).Append("\n");
      
      sb.Append("  Target: ").Append(Target).Append("\n");
      
      sb.Append("  Profiles: ").Append(Profiles).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
  
  
}