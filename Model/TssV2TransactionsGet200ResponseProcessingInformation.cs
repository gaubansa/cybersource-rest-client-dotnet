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
    /// TssV2TransactionsGet200ResponseProcessingInformation
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsGet200ResponseProcessingInformation :  IEquatable<TssV2TransactionsGet200ResponseProcessingInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsGet200ResponseProcessingInformation" /> class.
        /// </summary>
        /// <param name="PaymentSolution">Type of digital payment solution that is being used for the transaction. Possible Values:   - **visacheckout**: Visa Checkout.  - **001**: Apple Pay.  - **005**: Masterpass. Required for Masterpass transactions on OmniPay Direct.  - **006**: Android Pay.  - **008**: Samsung Pay. .</param>
        /// <param name="CommerceIndicator">Type of transaction. Some payment card companies use this information when determining discount rates. When you omit this field for **Ingenico ePayments**, the processor uses the default transaction type they have on file for you instead of the default value listed here. .</param>
        /// <param name="BusinessApplicationId">The description for this field is not available..</param>
        /// <param name="AuthorizationOptions">AuthorizationOptions.</param>
        /// <param name="BankTransferOptions">BankTransferOptions.</param>
        public TssV2TransactionsGet200ResponseProcessingInformation(string PaymentSolution = default(string), string CommerceIndicator = default(string), string BusinessApplicationId = default(string), TssV2TransactionsGet200ResponseProcessingInformationAuthorizationOptions AuthorizationOptions = default(TssV2TransactionsGet200ResponseProcessingInformationAuthorizationOptions), TssV2TransactionsGet200ResponseProcessingInformationBankTransferOptions BankTransferOptions = default(TssV2TransactionsGet200ResponseProcessingInformationBankTransferOptions))
        {
            this.PaymentSolution = PaymentSolution;
            this.CommerceIndicator = CommerceIndicator;
            this.BusinessApplicationId = BusinessApplicationId;
            this.AuthorizationOptions = AuthorizationOptions;
            this.BankTransferOptions = BankTransferOptions;
        }
        
        /// <summary>
        /// Type of digital payment solution that is being used for the transaction. Possible Values:   - **visacheckout**: Visa Checkout.  - **001**: Apple Pay.  - **005**: Masterpass. Required for Masterpass transactions on OmniPay Direct.  - **006**: Android Pay.  - **008**: Samsung Pay. 
        /// </summary>
        /// <value>Type of digital payment solution that is being used for the transaction. Possible Values:   - **visacheckout**: Visa Checkout.  - **001**: Apple Pay.  - **005**: Masterpass. Required for Masterpass transactions on OmniPay Direct.  - **006**: Android Pay.  - **008**: Samsung Pay. </value>
        [DataMember(Name="paymentSolution", EmitDefaultValue=false)]
        public string PaymentSolution { get; set; }

        /// <summary>
        /// Type of transaction. Some payment card companies use this information when determining discount rates. When you omit this field for **Ingenico ePayments**, the processor uses the default transaction type they have on file for you instead of the default value listed here. 
        /// </summary>
        /// <value>Type of transaction. Some payment card companies use this information when determining discount rates. When you omit this field for **Ingenico ePayments**, the processor uses the default transaction type they have on file for you instead of the default value listed here. </value>
        [DataMember(Name="commerceIndicator", EmitDefaultValue=false)]
        public string CommerceIndicator { get; set; }

        /// <summary>
        /// The description for this field is not available.
        /// </summary>
        /// <value>The description for this field is not available.</value>
        [DataMember(Name="businessApplicationId", EmitDefaultValue=false)]
        public string BusinessApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets AuthorizationOptions
        /// </summary>
        [DataMember(Name="authorizationOptions", EmitDefaultValue=false)]
        public TssV2TransactionsGet200ResponseProcessingInformationAuthorizationOptions AuthorizationOptions { get; set; }

        /// <summary>
        /// Gets or Sets BankTransferOptions
        /// </summary>
        [DataMember(Name="bankTransferOptions", EmitDefaultValue=false)]
        public TssV2TransactionsGet200ResponseProcessingInformationBankTransferOptions BankTransferOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsGet200ResponseProcessingInformation {\n");
            sb.Append("  PaymentSolution: ").Append(PaymentSolution).Append("\n");
            sb.Append("  CommerceIndicator: ").Append(CommerceIndicator).Append("\n");
            sb.Append("  BusinessApplicationId: ").Append(BusinessApplicationId).Append("\n");
            sb.Append("  AuthorizationOptions: ").Append(AuthorizationOptions).Append("\n");
            sb.Append("  BankTransferOptions: ").Append(BankTransferOptions).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsGet200ResponseProcessingInformation);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsGet200ResponseProcessingInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsGet200ResponseProcessingInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsGet200ResponseProcessingInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PaymentSolution == other.PaymentSolution ||
                    this.PaymentSolution != null &&
                    this.PaymentSolution.Equals(other.PaymentSolution)
                ) && 
                (
                    this.CommerceIndicator == other.CommerceIndicator ||
                    this.CommerceIndicator != null &&
                    this.CommerceIndicator.Equals(other.CommerceIndicator)
                ) && 
                (
                    this.BusinessApplicationId == other.BusinessApplicationId ||
                    this.BusinessApplicationId != null &&
                    this.BusinessApplicationId.Equals(other.BusinessApplicationId)
                ) && 
                (
                    this.AuthorizationOptions == other.AuthorizationOptions ||
                    this.AuthorizationOptions != null &&
                    this.AuthorizationOptions.Equals(other.AuthorizationOptions)
                ) && 
                (
                    this.BankTransferOptions == other.BankTransferOptions ||
                    this.BankTransferOptions != null &&
                    this.BankTransferOptions.Equals(other.BankTransferOptions)
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
                if (this.PaymentSolution != null)
                    hash = hash * 59 + this.PaymentSolution.GetHashCode();
                if (this.CommerceIndicator != null)
                    hash = hash * 59 + this.CommerceIndicator.GetHashCode();
                if (this.BusinessApplicationId != null)
                    hash = hash * 59 + this.BusinessApplicationId.GetHashCode();
                if (this.AuthorizationOptions != null)
                    hash = hash * 59 + this.AuthorizationOptions.GetHashCode();
                if (this.BankTransferOptions != null)
                    hash = hash * 59 + this.BankTransferOptions.GetHashCode();
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
            // PaymentSolution (string) maxLength
            if(this.PaymentSolution != null && this.PaymentSolution.Length > 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PaymentSolution, length must be less than 12.", new [] { "PaymentSolution" });
            }

            // CommerceIndicator (string) maxLength
            if(this.CommerceIndicator != null && this.CommerceIndicator.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CommerceIndicator, length must be less than 20.", new [] { "CommerceIndicator" });
            }

            yield break;
        }
    }

}
