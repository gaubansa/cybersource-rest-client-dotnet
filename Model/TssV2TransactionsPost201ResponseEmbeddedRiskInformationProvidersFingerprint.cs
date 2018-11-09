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
    /// TssV2TransactionsPost201ResponseEmbeddedRiskInformationProvidersFingerprint
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsPost201ResponseEmbeddedRiskInformationProvidersFingerprint :  IEquatable<TssV2TransactionsPost201ResponseEmbeddedRiskInformationProvidersFingerprint>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsPost201ResponseEmbeddedRiskInformationProvidersFingerprint" /> class.
        /// </summary>
        /// <param name="TrueIpaddress">The description for this field is not available..</param>
        /// <param name="Hash">The description for this field is not available..</param>
        /// <param name="SmartId">The description for this field is not available..</param>
        public TssV2TransactionsPost201ResponseEmbeddedRiskInformationProvidersFingerprint(string TrueIpaddress = default(string), string Hash = default(string), string SmartId = default(string))
        {
            this.TrueIpaddress = TrueIpaddress;
            this.Hash = Hash;
            this.SmartId = SmartId;
        }
        
        /// <summary>
        /// The description for this field is not available.
        /// </summary>
        /// <value>The description for this field is not available.</value>
        [DataMember(Name="true_ipaddress", EmitDefaultValue=false)]
        public string TrueIpaddress { get; set; }

        /// <summary>
        /// The description for this field is not available.
        /// </summary>
        /// <value>The description for this field is not available.</value>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        public string Hash { get; set; }

        /// <summary>
        /// The description for this field is not available.
        /// </summary>
        /// <value>The description for this field is not available.</value>
        [DataMember(Name="smartId", EmitDefaultValue=false)]
        public string SmartId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsPost201ResponseEmbeddedRiskInformationProvidersFingerprint {\n");
            sb.Append("  TrueIpaddress: ").Append(TrueIpaddress).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  SmartId: ").Append(SmartId).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsPost201ResponseEmbeddedRiskInformationProvidersFingerprint);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsPost201ResponseEmbeddedRiskInformationProvidersFingerprint instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsPost201ResponseEmbeddedRiskInformationProvidersFingerprint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsPost201ResponseEmbeddedRiskInformationProvidersFingerprint other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TrueIpaddress == other.TrueIpaddress ||
                    this.TrueIpaddress != null &&
                    this.TrueIpaddress.Equals(other.TrueIpaddress)
                ) && 
                (
                    this.Hash == other.Hash ||
                    this.Hash != null &&
                    this.Hash.Equals(other.Hash)
                ) && 
                (
                    this.SmartId == other.SmartId ||
                    this.SmartId != null &&
                    this.SmartId.Equals(other.SmartId)
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
                if (this.TrueIpaddress != null)
                    hash = hash * 59 + this.TrueIpaddress.GetHashCode();
                if (this.Hash != null)
                    hash = hash * 59 + this.Hash.GetHashCode();
                if (this.SmartId != null)
                    hash = hash * 59 + this.SmartId.GetHashCode();
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
            // TrueIpaddress (string) maxLength
            if(this.TrueIpaddress != null && this.TrueIpaddress.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TrueIpaddress, length must be less than 255.", new [] { "TrueIpaddress" });
            }

            // Hash (string) maxLength
            if(this.Hash != null && this.Hash.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Hash, length must be less than 255.", new [] { "Hash" });
            }

            // SmartId (string) maxLength
            if(this.SmartId != null && this.SmartId.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SmartId, length must be less than 255.", new [] { "SmartId" });
            }

            yield break;
        }
    }

}
