/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// ReportingV3NotificationofChangesGet200Response
    /// </summary>
    [DataContract]
    public partial class ReportingV3NotificationofChangesGet200Response :  IEquatable<ReportingV3NotificationofChangesGet200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingV3NotificationofChangesGet200Response" /> class.
        /// </summary>
        /// <param name="NotificationOfChanges">List of Notification Of Change Info values.</param>
        public ReportingV3NotificationofChangesGet200Response(List<ReportingV3NotificationofChangesGet200ResponseNotificationOfChanges> NotificationOfChanges = default(List<ReportingV3NotificationofChangesGet200ResponseNotificationOfChanges>))
        {
            this.NotificationOfChanges = NotificationOfChanges;
        }
        
        /// <summary>
        /// List of Notification Of Change Info values
        /// </summary>
        /// <value>List of Notification Of Change Info values</value>
        [DataMember(Name="notificationOfChanges", EmitDefaultValue=false)]
        public List<ReportingV3NotificationofChangesGet200ResponseNotificationOfChanges> NotificationOfChanges { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingV3NotificationofChangesGet200Response {\n");
            sb.Append("  NotificationOfChanges: ").Append(NotificationOfChanges).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ReportingV3NotificationofChangesGet200Response);
        }

        /// <summary>
        /// Returns true if ReportingV3NotificationofChangesGet200Response instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingV3NotificationofChangesGet200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingV3NotificationofChangesGet200Response other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NotificationOfChanges == other.NotificationOfChanges ||
                    this.NotificationOfChanges != null &&
                    this.NotificationOfChanges.SequenceEqual(other.NotificationOfChanges)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.NotificationOfChanges != null)
                    hash = hash * 59 + this.NotificationOfChanges.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
