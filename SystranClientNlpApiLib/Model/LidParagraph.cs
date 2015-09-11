using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.NlpClientLib.Model {

  /// <summary>
  /// Paragraph
  /// </summary>
  [DataContract]
  public class LidParagraph {
    
    /* Array of detected languages */
    [DataMember(Name="detectedLanguages", EmitDefaultValue=false)]
    public List<LidDetectedLanguage> DetectedLanguages { get; set; }

    
    /* Paragraph text */
    [DataMember(Name="source", EmitDefaultValue=false)]
    public string Source { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LidParagraph {\n");
      
      sb.Append("  DetectedLanguages: ").Append(DetectedLanguages).Append("\n");
      
      sb.Append("  Source: ").Append(Source).Append("\n");
      
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