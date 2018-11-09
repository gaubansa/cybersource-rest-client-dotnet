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
    /// Subscription Details
    /// </summary>
    [DataContract]
    public partial class ReportingV3ReportSubscriptionsGet200ResponseSubscriptions :  IEquatable<ReportingV3ReportSubscriptionsGet200ResponseSubscriptions>, IValidatableObject
    {
        /// <summary>
        /// Report Format
        /// </summary>
        /// <value>Report Format</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReportMimeTypeEnum
        {
            
            /// <summary>
            /// Enum ApplicationXml for "application/xml"
            /// </summary>
            [EnumMember(Value = "application/xml")]
            ApplicationXml,
            
            /// <summary>
            /// Enum TextCsv for "text/csv"
            /// </summary>
            [EnumMember(Value = "text/csv")]
            TextCsv
        }

        /// <summary>
        /// Report Frequency
        /// </summary>
        /// <value>Report Frequency</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReportFrequencyEnum
        {
            
            /// <summary>
            /// Enum DAILY for "DAILY"
            /// </summary>
            [EnumMember(Value = "DAILY")]
            DAILY,
            
            /// <summary>
            /// Enum WEEKLY for "WEEKLY"
            /// </summary>
            [EnumMember(Value = "WEEKLY")]
            WEEKLY,
            
            /// <summary>
            /// Enum MONTHLY for "MONTHLY"
            /// </summary>
            [EnumMember(Value = "MONTHLY")]
            MONTHLY
        }

        /// <summary>
        /// Report Format
        /// </summary>
        /// <value>Report Format</value>
        [DataMember(Name="reportMimeType", EmitDefaultValue=false)]
        public ReportMimeTypeEnum? ReportMimeType { get; set; }
        /// <summary>
        /// Report Frequency
        /// </summary>
        /// <value>Report Frequency</value>
        [DataMember(Name="reportFrequency", EmitDefaultValue=false)]
        public ReportFrequencyEnum? ReportFrequency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingV3ReportSubscriptionsGet200ResponseSubscriptions" /> class.
        /// </summary>
        /// <param name="OrganizationId">Organization Id.</param>
        /// <param name="ReportDefinitionId">Report Definition Id.</param>
        /// <param name="ReportDefinitionName">Report Definition.</param>
        /// <param name="ReportMimeType">Report Format.</param>
        /// <param name="ReportFrequency">Report Frequency.</param>
        /// <param name="ReportName">Report Name.</param>
        /// <param name="Timezone">Time Zone.</param>
        /// <param name="StartTime">Start Time.</param>
        /// <param name="StartDay">Start Day.</param>
        /// <param name="ReportFields">List of all fields String values.</param>        
        /// <param name="ReportPreferences">ReportPreferences.</param>
        /// <param name="SelectedMerchantGroupName">Selected name of the group..</param>
        public ReportingV3ReportSubscriptionsGet200ResponseSubscriptions(string OrganizationId = default(string), string ReportDefinitionId = default(string), string ReportDefinitionName = default(string), ReportMimeTypeEnum? ReportMimeType = default(ReportMimeTypeEnum?), ReportFrequencyEnum? ReportFrequency = default(ReportFrequencyEnum?), string ReportName = default(string), string Timezone = default(string), string StartTime = default(string), int? StartDay = default(int?), List<string> ReportFields = default(List<string>), ReportingV3ReportSubscriptionsGet200ResponseReportPreferences ReportPreferences = default(ReportingV3ReportSubscriptionsGet200ResponseReportPreferences), string SelectedMerchantGroupName = default(string))
        {
            this.OrganizationId = OrganizationId;
            this.ReportDefinitionId = ReportDefinitionId;
            this.ReportDefinitionName = ReportDefinitionName;
            this.ReportMimeType = ReportMimeType;
            this.ReportFrequency = ReportFrequency;
            this.ReportName = ReportName;
            this.Timezone = Timezone;
            this.StartTime = StartTime;
            this.StartDay = StartDay;
            this.ReportFields = ReportFields;
            //this.ReportFilters = ReportFilters;
            this.ReportPreferences = ReportPreferences;
            this.SelectedMerchantGroupName = SelectedMerchantGroupName;
        }
        
        /// <summary>
        /// Organization Id
        /// </summary>
        /// <value>Organization Id</value>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Report Definition Id
        /// </summary>
        /// <value>Report Definition Id</value>
        [DataMember(Name="reportDefinitionId", EmitDefaultValue=false)]
        public string ReportDefinitionId { get; set; }

        /// <summary>
        /// Report Definition
        /// </summary>
        /// <value>Report Definition</value>
        [DataMember(Name="reportDefinitionName", EmitDefaultValue=false)]
        public string ReportDefinitionName { get; set; }



        /// <summary>
        /// Report Name
        /// </summary>
        /// <value>Report Name</value>
        [DataMember(Name="reportName", EmitDefaultValue=false)]
        public string ReportName { get; set; }

        /// <summary>
        /// Time Zone
        /// </summary>
        /// <value>Time Zone</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Start Time
        /// </summary>
        /// <value>Start Time</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// Start Day
        /// </summary>
        /// <value>Start Day</value>
        [DataMember(Name="startDay", EmitDefaultValue=false)]
        public int? StartDay { get; set; }

        /// <summary>
        /// List of all fields String values
        /// </summary>
        /// <value>List of all fields String values</value>
        [DataMember(Name="reportFields", EmitDefaultValue=false)]
        public List<string> ReportFields { get; set; }

        /// <summary>
        /// List of filters to apply
        /// </summary>
        /// <value>List of filters to apply</value>
        //[DataMember(Name="reportFilters", EmitDefaultValue=false)]
        //public string ReportFilters { get; set; }

        /// <summary>
        /// Gets or Sets ReportPreferences
        /// </summary>
        [DataMember(Name="reportPreferences", EmitDefaultValue=false)]
        public ReportingV3ReportSubscriptionsGet200ResponseReportPreferences ReportPreferences { get; set; }

        /// <summary>
        /// Selected name of the group.
        /// </summary>
        /// <value>Selected name of the group.</value>
        [DataMember(Name="selectedMerchantGroupName", EmitDefaultValue=false)]
        public string SelectedMerchantGroupName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingV3ReportSubscriptionsGet200ResponseSubscriptions {\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  ReportDefinitionId: ").Append(ReportDefinitionId).Append("\n");
            sb.Append("  ReportDefinitionName: ").Append(ReportDefinitionName).Append("\n");
            sb.Append("  ReportMimeType: ").Append(ReportMimeType).Append("\n");
            sb.Append("  ReportFrequency: ").Append(ReportFrequency).Append("\n");
            sb.Append("  ReportName: ").Append(ReportName).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  StartDay: ").Append(StartDay).Append("\n");
            sb.Append("  ReportFields: ").Append(ReportFields).Append("\n");
            //sb.Append("  ReportFilters: ").Append(ReportFilters).Append("\n");
            sb.Append("  ReportPreferences: ").Append(ReportPreferences).Append("\n");
            sb.Append("  SelectedMerchantGroupName: ").Append(SelectedMerchantGroupName).Append("\n");
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
            return this.Equals(obj as ReportingV3ReportSubscriptionsGet200ResponseSubscriptions);
        }

        /// <summary>
        /// Returns true if ReportingV3ReportSubscriptionsGet200ResponseSubscriptions instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingV3ReportSubscriptionsGet200ResponseSubscriptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingV3ReportSubscriptionsGet200ResponseSubscriptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OrganizationId == other.OrganizationId ||
                    this.OrganizationId != null &&
                    this.OrganizationId.Equals(other.OrganizationId)
                ) && 
                (
                    this.ReportDefinitionId == other.ReportDefinitionId ||
                    this.ReportDefinitionId != null &&
                    this.ReportDefinitionId.Equals(other.ReportDefinitionId)
                ) && 
                (
                    this.ReportDefinitionName == other.ReportDefinitionName ||
                    this.ReportDefinitionName != null &&
                    this.ReportDefinitionName.Equals(other.ReportDefinitionName)
                ) && 
                (
                    this.ReportMimeType == other.ReportMimeType ||
                    this.ReportMimeType != null &&
                    this.ReportMimeType.Equals(other.ReportMimeType)
                ) && 
                (
                    this.ReportFrequency == other.ReportFrequency ||
                    this.ReportFrequency != null &&
                    this.ReportFrequency.Equals(other.ReportFrequency)
                ) && 
                (
                    this.ReportName == other.ReportName ||
                    this.ReportName != null &&
                    this.ReportName.Equals(other.ReportName)
                ) && 
                (
                    this.Timezone == other.Timezone ||
                    this.Timezone != null &&
                    this.Timezone.Equals(other.Timezone)
                ) && 
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) && 
                (
                    this.StartDay == other.StartDay ||
                    this.StartDay != null &&
                    this.StartDay.Equals(other.StartDay)
                ) && 
                (
                    this.ReportFields == other.ReportFields ||
                    this.ReportFields != null &&
                    this.ReportFields.SequenceEqual(other.ReportFields)
                ) && 
                //(
                //    this.ReportFilters == other.ReportFilters ||
                //    this.ReportFilters != null &&
                //    this.ReportFilters.SequenceEqual(other.ReportFilters)
                //) && 
                (
                    this.ReportPreferences == other.ReportPreferences ||
                    this.ReportPreferences != null &&
                    this.ReportPreferences.Equals(other.ReportPreferences)
                ) && 
                (
                    this.SelectedMerchantGroupName == other.SelectedMerchantGroupName ||
                    this.SelectedMerchantGroupName != null &&
                    this.SelectedMerchantGroupName.Equals(other.SelectedMerchantGroupName)
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
                if (this.OrganizationId != null)
                    hash = hash * 59 + this.OrganizationId.GetHashCode();
                if (this.ReportDefinitionId != null)
                    hash = hash * 59 + this.ReportDefinitionId.GetHashCode();
                if (this.ReportDefinitionName != null)
                    hash = hash * 59 + this.ReportDefinitionName.GetHashCode();
                if (this.ReportMimeType != null)
                    hash = hash * 59 + this.ReportMimeType.GetHashCode();
                if (this.ReportFrequency != null)
                    hash = hash * 59 + this.ReportFrequency.GetHashCode();
                if (this.ReportName != null)
                    hash = hash * 59 + this.ReportName.GetHashCode();
                if (this.Timezone != null)
                    hash = hash * 59 + this.Timezone.GetHashCode();
                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();
                if (this.StartDay != null)
                    hash = hash * 59 + this.StartDay.GetHashCode();
                if (this.ReportFields != null)
                    hash = hash * 59 + this.ReportFields.GetHashCode();
                //if (this.ReportFilters != null)
                //    hash = hash * 59 + this.ReportFilters.GetHashCode();
                if (this.ReportPreferences != null)
                    hash = hash * 59 + this.ReportPreferences.GetHashCode();
                if (this.SelectedMerchantGroupName != null)
                    hash = hash * 59 + this.SelectedMerchantGroupName.GetHashCode();
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
