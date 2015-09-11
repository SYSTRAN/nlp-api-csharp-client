using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.NlpClientLib.Model {

  /// <summary>
  /// Response of a Lemma extract request
  /// </summary>
  [DataContract]
  public class MorphologyExtractLemmaResponse {
    
    /* Lemma text elements */
    [DataMember(Name="lemmas", EmitDefaultValue=false)]
    public List<LemmaAnnotation> Lemmas { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MorphologyExtractLemmaResponse {\n");
      
      sb.Append("  Lemmas: ").Append(Lemmas).Append("\n");
      
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