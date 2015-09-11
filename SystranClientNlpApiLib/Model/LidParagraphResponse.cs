using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.NlpClientLib.Model {

  /// <summary>
  /// Response of a Lid Paragraph request
  /// </summary>
  [DataContract]
  public class LidParagraphResponse {
    
    /* Array of paragraphs */
    [DataMember(Name="paragraphs", EmitDefaultValue=false)]
    public List<LidParagraph> Paragraphs { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LidParagraphResponse {\n");
      
      sb.Append("  Paragraphs: ").Append(Paragraphs).Append("\n");
      
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