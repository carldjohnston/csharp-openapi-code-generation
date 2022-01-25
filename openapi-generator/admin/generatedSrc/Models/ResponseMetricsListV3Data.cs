/*
 * CDR Admin API
 *
 * Data Holder Consumer Data Standards Administration End Points created by the Data Standards Body (DSB), with the Data Standards Chair as the decision maker
 *
 * The version of the OpenAPI document: 1.15.0
 * Contact: contact@consumerdatastandards.gov.au
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Agl.Cdr.Admin
{
    /// <summary>
    /// ResponseMetricsListV3Data
    /// </summary>
    [DataContract(Name = "ResponseMetricsListV3_data")]
    public partial class ResponseMetricsListV3Data : IEquatable<ResponseMetricsListV3Data>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseMetricsListV3Data" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResponseMetricsListV3Data() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseMetricsListV3Data" /> class.
        /// </summary>
        /// <param name="requestTime">The date and time that the metrics in this payload were requested. (required).</param>
        /// <param name="availability">availability (required).</param>
        /// <param name="performance">performance (required).</param>
        /// <param name="invocations">invocations (required).</param>
        /// <param name="averageResponse">averageResponse (required).</param>
        /// <param name="sessionCount">sessionCount (required).</param>
        /// <param name="averageTps">averageTps (required).</param>
        /// <param name="peakTps">peakTps (required).</param>
        /// <param name="errors">errors (required).</param>
        /// <param name="rejections">rejections (required).</param>
        /// <param name="customerCount">Number of customers with active authorisations at the time of the call (required).</param>
        /// <param name="recipientCount">Number of Data Recipient Software Products with active authorisations at the time of the call (required).</param>
        /// <param name="secondaryHolder">secondaryHolder.</param>
        public ResponseMetricsListV3Data(string requestTime = default(string), AvailabilityMetrics availability = default(AvailabilityMetrics), PerformanceMetrics performance = default(PerformanceMetrics), InvocationMetricsV2 invocations = default(InvocationMetricsV2), AverageResponseMetricsV2 averageResponse = default(AverageResponseMetricsV2), SessionCountMetrics sessionCount = default(SessionCountMetrics), AverageTPSMetrics averageTps = default(AverageTPSMetrics), PeakTPSMetrics peakTps = default(PeakTPSMetrics), ErrorMetrics errors = default(ErrorMetrics), RejectionMetricsV2 rejections = default(RejectionMetricsV2), int customerCount = default(int), int recipientCount = default(int), SecondaryHolderMetrics secondaryHolder = default(SecondaryHolderMetrics))
        {
            // to ensure "requestTime" is required (not null)
            this.RequestTime = requestTime ?? throw new ArgumentNullException("requestTime is a required property for ResponseMetricsListV3Data and cannot be null");
            // to ensure "availability" is required (not null)
            this.Availability = availability ?? throw new ArgumentNullException("availability is a required property for ResponseMetricsListV3Data and cannot be null");
            // to ensure "performance" is required (not null)
            this.Performance = performance ?? throw new ArgumentNullException("performance is a required property for ResponseMetricsListV3Data and cannot be null");
            // to ensure "invocations" is required (not null)
            this.Invocations = invocations ?? throw new ArgumentNullException("invocations is a required property for ResponseMetricsListV3Data and cannot be null");
            // to ensure "averageResponse" is required (not null)
            this.AverageResponse = averageResponse ?? throw new ArgumentNullException("averageResponse is a required property for ResponseMetricsListV3Data and cannot be null");
            // to ensure "sessionCount" is required (not null)
            this.SessionCount = sessionCount ?? throw new ArgumentNullException("sessionCount is a required property for ResponseMetricsListV3Data and cannot be null");
            // to ensure "averageTps" is required (not null)
            this.AverageTps = averageTps ?? throw new ArgumentNullException("averageTps is a required property for ResponseMetricsListV3Data and cannot be null");
            // to ensure "peakTps" is required (not null)
            this.PeakTps = peakTps ?? throw new ArgumentNullException("peakTps is a required property for ResponseMetricsListV3Data and cannot be null");
            // to ensure "errors" is required (not null)
            this.Errors = errors ?? throw new ArgumentNullException("errors is a required property for ResponseMetricsListV3Data and cannot be null");
            // to ensure "rejections" is required (not null)
            this.Rejections = rejections ?? throw new ArgumentNullException("rejections is a required property for ResponseMetricsListV3Data and cannot be null");
            this.CustomerCount = customerCount;
            this.RecipientCount = recipientCount;
            this.SecondaryHolder = secondaryHolder;
        }

        /// <summary>
        /// The date and time that the metrics in this payload were requested.
        /// </summary>
        /// <value>The date and time that the metrics in this payload were requested.</value>
        [DataMember(Name = "requestTime", IsRequired = true, EmitDefaultValue = false)]
        public string RequestTime { get; set; }

        /// <summary>
        /// Gets or Sets Availability
        /// </summary>
        [DataMember(Name = "availability", IsRequired = true, EmitDefaultValue = false)]
        public AvailabilityMetrics Availability { get; set; }

        /// <summary>
        /// Gets or Sets Performance
        /// </summary>
        [DataMember(Name = "performance", IsRequired = true, EmitDefaultValue = false)]
        public PerformanceMetrics Performance { get; set; }

        /// <summary>
        /// Gets or Sets Invocations
        /// </summary>
        [DataMember(Name = "invocations", IsRequired = true, EmitDefaultValue = false)]
        public InvocationMetricsV2 Invocations { get; set; }

        /// <summary>
        /// Gets or Sets AverageResponse
        /// </summary>
        [DataMember(Name = "averageResponse", IsRequired = true, EmitDefaultValue = false)]
        public AverageResponseMetricsV2 AverageResponse { get; set; }

        /// <summary>
        /// Gets or Sets SessionCount
        /// </summary>
        [DataMember(Name = "sessionCount", IsRequired = true, EmitDefaultValue = false)]
        public SessionCountMetrics SessionCount { get; set; }

        /// <summary>
        /// Gets or Sets AverageTps
        /// </summary>
        [DataMember(Name = "averageTps", IsRequired = true, EmitDefaultValue = false)]
        public AverageTPSMetrics AverageTps { get; set; }

        /// <summary>
        /// Gets or Sets PeakTps
        /// </summary>
        [DataMember(Name = "peakTps", IsRequired = true, EmitDefaultValue = false)]
        public PeakTPSMetrics PeakTps { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", IsRequired = true, EmitDefaultValue = false)]
        public ErrorMetrics Errors { get; set; }

        /// <summary>
        /// Gets or Sets Rejections
        /// </summary>
        [DataMember(Name = "rejections", IsRequired = true, EmitDefaultValue = false)]
        public RejectionMetricsV2 Rejections { get; set; }

        /// <summary>
        /// Number of customers with active authorisations at the time of the call
        /// </summary>
        /// <value>Number of customers with active authorisations at the time of the call</value>
        [DataMember(Name = "customerCount", IsRequired = true, EmitDefaultValue = false)]
        public int CustomerCount { get; set; }

        /// <summary>
        /// Number of Data Recipient Software Products with active authorisations at the time of the call
        /// </summary>
        /// <value>Number of Data Recipient Software Products with active authorisations at the time of the call</value>
        [DataMember(Name = "recipientCount", IsRequired = true, EmitDefaultValue = false)]
        public int RecipientCount { get; set; }

        /// <summary>
        /// Gets or Sets SecondaryHolder
        /// </summary>
        [DataMember(Name = "secondaryHolder", EmitDefaultValue = false)]
        public SecondaryHolderMetrics SecondaryHolder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseMetricsListV3Data {\n");
            sb.Append("  RequestTime: ").Append(RequestTime).Append("\n");
            sb.Append("  Availability: ").Append(Availability).Append("\n");
            sb.Append("  Performance: ").Append(Performance).Append("\n");
            sb.Append("  Invocations: ").Append(Invocations).Append("\n");
            sb.Append("  AverageResponse: ").Append(AverageResponse).Append("\n");
            sb.Append("  SessionCount: ").Append(SessionCount).Append("\n");
            sb.Append("  AverageTps: ").Append(AverageTps).Append("\n");
            sb.Append("  PeakTps: ").Append(PeakTps).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Rejections: ").Append(Rejections).Append("\n");
            sb.Append("  CustomerCount: ").Append(CustomerCount).Append("\n");
            sb.Append("  RecipientCount: ").Append(RecipientCount).Append("\n");
            sb.Append("  SecondaryHolder: ").Append(SecondaryHolder).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResponseMetricsListV3Data);
        }

        /// <summary>
        /// Returns true if ResponseMetricsListV3Data instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponseMetricsListV3Data to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseMetricsListV3Data input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestTime == input.RequestTime ||
                    (this.RequestTime != null &&
                    this.RequestTime.Equals(input.RequestTime))
                ) && 
                (
                    this.Availability == input.Availability ||
                    (this.Availability != null &&
                    this.Availability.Equals(input.Availability))
                ) && 
                (
                    this.Performance == input.Performance ||
                    (this.Performance != null &&
                    this.Performance.Equals(input.Performance))
                ) && 
                (
                    this.Invocations == input.Invocations ||
                    (this.Invocations != null &&
                    this.Invocations.Equals(input.Invocations))
                ) && 
                (
                    this.AverageResponse == input.AverageResponse ||
                    (this.AverageResponse != null &&
                    this.AverageResponse.Equals(input.AverageResponse))
                ) && 
                (
                    this.SessionCount == input.SessionCount ||
                    (this.SessionCount != null &&
                    this.SessionCount.Equals(input.SessionCount))
                ) && 
                (
                    this.AverageTps == input.AverageTps ||
                    (this.AverageTps != null &&
                    this.AverageTps.Equals(input.AverageTps))
                ) && 
                (
                    this.PeakTps == input.PeakTps ||
                    (this.PeakTps != null &&
                    this.PeakTps.Equals(input.PeakTps))
                ) && 
                (
                    this.Errors == input.Errors ||
                    (this.Errors != null &&
                    this.Errors.Equals(input.Errors))
                ) && 
                (
                    this.Rejections == input.Rejections ||
                    (this.Rejections != null &&
                    this.Rejections.Equals(input.Rejections))
                ) && 
                (
                    this.CustomerCount == input.CustomerCount ||
                    this.CustomerCount.Equals(input.CustomerCount)
                ) && 
                (
                    this.RecipientCount == input.RecipientCount ||
                    this.RecipientCount.Equals(input.RecipientCount)
                ) && 
                (
                    this.SecondaryHolder == input.SecondaryHolder ||
                    (this.SecondaryHolder != null &&
                    this.SecondaryHolder.Equals(input.SecondaryHolder))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.RequestTime != null)
                    hashCode = hashCode * 59 + this.RequestTime.GetHashCode();
                if (this.Availability != null)
                    hashCode = hashCode * 59 + this.Availability.GetHashCode();
                if (this.Performance != null)
                    hashCode = hashCode * 59 + this.Performance.GetHashCode();
                if (this.Invocations != null)
                    hashCode = hashCode * 59 + this.Invocations.GetHashCode();
                if (this.AverageResponse != null)
                    hashCode = hashCode * 59 + this.AverageResponse.GetHashCode();
                if (this.SessionCount != null)
                    hashCode = hashCode * 59 + this.SessionCount.GetHashCode();
                if (this.AverageTps != null)
                    hashCode = hashCode * 59 + this.AverageTps.GetHashCode();
                if (this.PeakTps != null)
                    hashCode = hashCode * 59 + this.PeakTps.GetHashCode();
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
                if (this.Rejections != null)
                    hashCode = hashCode * 59 + this.Rejections.GetHashCode();
                hashCode = hashCode * 59 + this.CustomerCount.GetHashCode();
                hashCode = hashCode * 59 + this.RecipientCount.GetHashCode();
                if (this.SecondaryHolder != null)
                    hashCode = hashCode * 59 + this.SecondaryHolder.GetHashCode();
                return hashCode;
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
