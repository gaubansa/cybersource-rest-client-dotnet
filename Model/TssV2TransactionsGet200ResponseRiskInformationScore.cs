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
    /// TssV2TransactionsGet200ResponseRiskInformationScore
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsGet200ResponseRiskInformationScore :  IEquatable<TssV2TransactionsGet200ResponseRiskInformationScore>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsGet200ResponseRiskInformationScore" /> class.
        /// </summary>
        /// <param name="FactorCodes">Array of factor codes..</param>
        /// <param name="Result">The description for this field is not available. .</param>
        public TssV2TransactionsGet200ResponseRiskInformationScore(List<string> FactorCodes = default(List<string>), int? Result = default(int?))
        {
            this.FactorCodes = FactorCodes;
            this.Result = Result;
        }
        
        /// <summary>
        /// Array of factor codes.
        /// </summary>
        /// <value>Array of factor codes.</value>
        [DataMember(Name="factorCodes", EmitDefaultValue=false)]
        public List<string> FactorCodes { get; set; }

        /// <summary>
        /// The description for this field is not available. 
        /// </summary>
        /// <value>The description for this field is not available. </value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public int? Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsGet200ResponseRiskInformationScore {\n");
            sb.Append("  FactorCodes: ").Append(FactorCodes).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsGet200ResponseRiskInformationScore);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsGet200ResponseRiskInformationScore instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsGet200ResponseRiskInformationScore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsGet200ResponseRiskInformationScore other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FactorCodes == other.FactorCodes ||
                    this.FactorCodes != null &&
                    this.FactorCodes.SequenceEqual(other.FactorCodes)
                ) && 
                (
                    this.Result == other.Result ||
                    this.Result != null &&
                    this.Result.Equals(other.Result)
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
                if (this.FactorCodes != null)
                    hash = hash * 59 + this.FactorCodes.GetHashCode();
                if (this.Result != null)
                    hash = hash * 59 + this.Result.GetHashCode();
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
