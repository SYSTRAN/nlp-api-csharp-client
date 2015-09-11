using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.NlpClientLib.Model {

  /// <summary>
  /// Detected Language
  /// </summary>
  [DataContract]
  public class LidDetectedLanguage {
    
    /* Language */
    [DataMember(Name="lang", EmitDefaultValue=false)]
    public string Lang { get; set; }

    
    /* Confidence */
    [DataMember(Name="confidence", EmitDefaultValue=false)]
    public double? Confidence { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LidDetectedLanguage {\n");
      
      sb.Append("  Lang: ").Append(Lang).Append("\n");
      
      sb.Append("  Confidence: ").Append(Confidence).Append("\n");
      
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