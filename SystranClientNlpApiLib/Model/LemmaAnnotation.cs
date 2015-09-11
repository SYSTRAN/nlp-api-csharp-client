using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.NlpClientLib.Model {

  /// <summary>
  /// Lemma annotation
  /// </summary>
  [DataContract]
  public class LemmaAnnotation {
    
    /* Text */
    [DataMember(Name="text", EmitDefaultValue=false)]
    public string Text { get; set; }

    
    /* Lemma */
    [DataMember(Name="lemma", EmitDefaultValue=false)]
    public string Lemma { get; set; }

    
    /* Start offset */
    [DataMember(Name="start", EmitDefaultValue=false)]
    public int? Start { get; set; }

    
    /* End offset */
    [DataMember(Name="end", EmitDefaultValue=false)]
    public int? End { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LemmaAnnotation {\n");
      
      sb.Append("  Text: ").Append(Text).Append("\n");
      
      sb.Append("  Lemma: ").Append(Lemma).Append("\n");
      
      sb.Append("  Start: ").Append(Start).Append("\n");
      
      sb.Append("  End: ").Append(End).Append("\n");
      
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