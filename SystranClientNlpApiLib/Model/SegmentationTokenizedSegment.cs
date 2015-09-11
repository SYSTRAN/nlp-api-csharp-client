using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.NlpClientLib.Model {

  /// <summary>
  /// Segment with tokenized content
  /// </summary>
  [DataContract]
  public class SegmentationTokenizedSegment {
    
    /* Segment */
    [DataMember(Name="source", EmitDefaultValue=false)]
    public string Source { get; set; }

    
    /* Array of tokens */
    [DataMember(Name="tokens", EmitDefaultValue=false)]
    public List<SegmentationToken> Tokens { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SegmentationTokenizedSegment {\n");
      
      sb.Append("  Source: ").Append(Source).Append("\n");
      
      sb.Append("  Tokens: ").Append(Tokens).Append("\n");
      
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