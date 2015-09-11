using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.NlpClientLib.Model {

  /// <summary>
  /// Entity annotations for one segment
  /// </summary>
  [DataContract]
  public class NerSegmentAnnotation {
    
    /* Text segment */
    [DataMember(Name="source", EmitDefaultValue=false)]
    public string Source { get; set; }

    
    /* Array of found entities */
    [DataMember(Name="entities", EmitDefaultValue=false)]
    public List<NerEntityAnnotation> Entities { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NerSegmentAnnotation {\n");
      
      sb.Append("  Source: ").Append(Source).Append("\n");
      
      sb.Append("  Entities: ").Append(Entities).Append("\n");
      
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