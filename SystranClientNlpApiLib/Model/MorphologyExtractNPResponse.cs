using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.NlpClientLib.Model {

  /// <summary>
  /// Response of a Noun-Phrase/Chunk extract request
  /// </summary>
  [DataContract]
  public class MorphologyExtractNPResponse {
    
    /* List of extracted chunks */
    [DataMember(Name="chunks", EmitDefaultValue=false)]
    public List<ChunkAnnotation> Chunks { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MorphologyExtractNPResponse {\n");
      
      sb.Append("  Chunks: ").Append(Chunks).Append("\n");
      
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