/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
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
    /// The place of business where you accept/approve the customer’s order, thereby becoming contractually obligated to make the sale.
    /// </summary>
    [DataContract]
    public partial class Vasv2taxOrderInformationOrderAcceptance :  IEquatable<Vasv2taxOrderInformationOrderAcceptance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Vasv2taxOrderInformationOrderAcceptance" /> class.
        /// </summary>
        /// <param name="Locality">Order acceptance city. This field is not used unless the &#x60;orderInformation.orderAcceptance.administrativeArea&#x60; and &#x60;orderInformation.orderAcceptance.country&#x60; fields are present.  **NOTE** If this field appears in a &#x60;lineItems&#x60; object, then the value of this field in the &#x60;lineItems&#x60; object overrides the value of the corresponding field at the request-level or order-level object.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. The place of business where you accept/approve the customer’s order, thereby becoming contractually obligated to make the sale. .</param>
        /// <param name="AdministrativeArea">Order acceptance state. This field is not used unless the &#x60;orderInformation.orderAcceptance.locality&#x60; and &#x60;orderInformation.orderAcceptance.country&#x60; fields are present. Use the [State, Province, and Territory Codes for the United States and Canada](https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf).  **NOTE** If this field appears in a &#x60;lineItems&#x60; object, then the value of this field in the &#x60;lineItems&#x60; object overrides the value of the corresponding field at the request-level or order-level object.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. The place of business where you accept/approve the customer’s order, thereby becoming contractually obligated to make the sale. .</param>
        /// <param name="PostalCode">Order acceptance postal code. This field is not used unless the &#x60;orderInformation.orderAcceptance.locality&#x60;, &#x60;orderInformation.orderAcceptance.administrativeArea&#x60;, and &#x60;orderInformation.orderAcceptance.country&#x60; fields are present. Must be sent at the line or offer level to be surfaced in the Tax Detail Report.  **NOTE** If this field appears in a &#x60;lineItems&#x60; object, then the value of this field in the &#x60;lineItems&#x60; object overrides the value of the corresponding field at the request-level or order-level object.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. The place of business where you accept/approve the customer’s order, thereby becoming contractually obligated to make the sale. .</param>
        /// <param name="Country">Order acceptance country. This field is not used unless the &#x60;orderInformation.orderAcceptance.administrativeArea&#x60; and &#x60;orderInformation.orderAcceptance.locality&#x60; fields are present. Use the [ISO Standard Country Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf)  **NOTE** If this field appears in a &#x60;lineItems&#x60; object, then the value of this field in the &#x60;lineItems&#x60; object overrides the value of the corresponding field at the request-level or order-level object.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. The place of business where you accept/approve the customer’s order, thereby becoming contractually obligated to make the sale. .</param>
        public Vasv2taxOrderInformationOrderAcceptance(string Locality = default(string), string AdministrativeArea = default(string), string PostalCode = default(string), string Country = default(string))
        {
            this.Locality = Locality;
            this.AdministrativeArea = AdministrativeArea;
            this.PostalCode = PostalCode;
            this.Country = Country;
        }
        
        /// <summary>
        /// Order acceptance city. This field is not used unless the &#x60;orderInformation.orderAcceptance.administrativeArea&#x60; and &#x60;orderInformation.orderAcceptance.country&#x60; fields are present.  **NOTE** If this field appears in a &#x60;lineItems&#x60; object, then the value of this field in the &#x60;lineItems&#x60; object overrides the value of the corresponding field at the request-level or order-level object.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. The place of business where you accept/approve the customer’s order, thereby becoming contractually obligated to make the sale. 
        /// </summary>
        /// <value>Order acceptance city. This field is not used unless the &#x60;orderInformation.orderAcceptance.administrativeArea&#x60; and &#x60;orderInformation.orderAcceptance.country&#x60; fields are present.  **NOTE** If this field appears in a &#x60;lineItems&#x60; object, then the value of this field in the &#x60;lineItems&#x60; object overrides the value of the corresponding field at the request-level or order-level object.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. The place of business where you accept/approve the customer’s order, thereby becoming contractually obligated to make the sale. </value>
        [DataMember(Name="locality", EmitDefaultValue=false)]
        public string Locality { get; set; }

        /// <summary>
        /// Order acceptance state. This field is not used unless the &#x60;orderInformation.orderAcceptance.locality&#x60; and &#x60;orderInformation.orderAcceptance.country&#x60; fields are present. Use the [State, Province, and Territory Codes for the United States and Canada](https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf).  **NOTE** If this field appears in a &#x60;lineItems&#x60; object, then the value of this field in the &#x60;lineItems&#x60; object overrides the value of the corresponding field at the request-level or order-level object.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. The place of business where you accept/approve the customer’s order, thereby becoming contractually obligated to make the sale. 
        /// </summary>
        /// <value>Order acceptance state. This field is not used unless the &#x60;orderInformation.orderAcceptance.locality&#x60; and &#x60;orderInformation.orderAcceptance.country&#x60; fields are present. Use the [State, Province, and Territory Codes for the United States and Canada](https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf).  **NOTE** If this field appears in a &#x60;lineItems&#x60; object, then the value of this field in the &#x60;lineItems&#x60; object overrides the value of the corresponding field at the request-level or order-level object.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. The place of business where you accept/approve the customer’s order, thereby becoming contractually obligated to make the sale. </value>
        [DataMember(Name="administrativeArea", EmitDefaultValue=false)]
        public string AdministrativeArea { get; set; }

        /// <summary>
        /// Order acceptance postal code. This field is not used unless the &#x60;orderInformation.orderAcceptance.locality&#x60;, &#x60;orderInformation.orderAcceptance.administrativeArea&#x60;, and &#x60;orderInformation.orderAcceptance.country&#x60; fields are present. Must be sent at the line or offer level to be surfaced in the Tax Detail Report.  **NOTE** If this field appears in a &#x60;lineItems&#x60; object, then the value of this field in the &#x60;lineItems&#x60; object overrides the value of the corresponding field at the request-level or order-level object.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. The place of business where you accept/approve the customer’s order, thereby becoming contractually obligated to make the sale. 
        /// </summary>
        /// <value>Order acceptance postal code. This field is not used unless the &#x60;orderInformation.orderAcceptance.locality&#x60;, &#x60;orderInformation.orderAcceptance.administrativeArea&#x60;, and &#x60;orderInformation.orderAcceptance.country&#x60; fields are present. Must be sent at the line or offer level to be surfaced in the Tax Detail Report.  **NOTE** If this field appears in a &#x60;lineItems&#x60; object, then the value of this field in the &#x60;lineItems&#x60; object overrides the value of the corresponding field at the request-level or order-level object.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. The place of business where you accept/approve the customer’s order, thereby becoming contractually obligated to make the sale. </value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Order acceptance country. This field is not used unless the &#x60;orderInformation.orderAcceptance.administrativeArea&#x60; and &#x60;orderInformation.orderAcceptance.locality&#x60; fields are present. Use the [ISO Standard Country Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf)  **NOTE** If this field appears in a &#x60;lineItems&#x60; object, then the value of this field in the &#x60;lineItems&#x60; object overrides the value of the corresponding field at the request-level or order-level object.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. The place of business where you accept/approve the customer’s order, thereby becoming contractually obligated to make the sale. 
        /// </summary>
        /// <value>Order acceptance country. This field is not used unless the &#x60;orderInformation.orderAcceptance.administrativeArea&#x60; and &#x60;orderInformation.orderAcceptance.locality&#x60; fields are present. Use the [ISO Standard Country Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf)  **NOTE** If this field appears in a &#x60;lineItems&#x60; object, then the value of this field in the &#x60;lineItems&#x60; object overrides the value of the corresponding field at the request-level or order-level object.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. The place of business where you accept/approve the customer’s order, thereby becoming contractually obligated to make the sale. </value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Vasv2taxOrderInformationOrderAcceptance {\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  AdministrativeArea: ").Append(AdministrativeArea).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(obj as Vasv2taxOrderInformationOrderAcceptance);
        }

        /// <summary>
        /// Returns true if Vasv2taxOrderInformationOrderAcceptance instances are equal
        /// </summary>
        /// <param name="other">Instance of Vasv2taxOrderInformationOrderAcceptance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Vasv2taxOrderInformationOrderAcceptance other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Locality == other.Locality ||
                    this.Locality != null &&
                    this.Locality.Equals(other.Locality)
                ) && 
                (
                    this.AdministrativeArea == other.AdministrativeArea ||
                    this.AdministrativeArea != null &&
                    this.AdministrativeArea.Equals(other.AdministrativeArea)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
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
                if (this.Locality != null)
                    hash = hash * 59 + this.Locality.GetHashCode();
                if (this.AdministrativeArea != null)
                    hash = hash * 59 + this.AdministrativeArea.GetHashCode();
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
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
            // Locality (string) maxLength
            if(this.Locality != null && this.Locality.Length >= 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Locality, length must be less than or equal to 50.", new [] { "Locality" });
            }

            // AdministrativeArea (string) maxLength
            if(this.AdministrativeArea != null && this.AdministrativeArea.Length >= 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AdministrativeArea, length must be less than or equal to 2.", new [] { "AdministrativeArea" });
            }

            // PostalCode (string) maxLength
            if(this.PostalCode != null && this.PostalCode.Length >= 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostalCode, length must be less than or equal to 10.", new [] { "PostalCode" });
            }

            // Country (string) maxLength
            if(this.Country != null && this.Country.Length >= 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, length must be less than or equal to 2.", new [] { "Country" });
            }

            yield break;
        }
    }

}