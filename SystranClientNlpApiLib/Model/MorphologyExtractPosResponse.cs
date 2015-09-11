using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.NlpClientLib.Model {

  /// <summary>
  /// Response of a Part of speech extract request
  /// </summary>
  [DataContract]
  public class MorphologyExtractPosResponse {
    
    /* Part of speech per text elements */
    [DataMember(Name="partsOfSpeech", EmitDefaultValue=false)]
    public List<PosAnnotation> PartsOfSpeech { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MorphologyExtractPosResponse {\n");
      
      sb.Append("  PartsOfSpeech: ").Append(PartsOfSpeech).Append("\n");
      
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