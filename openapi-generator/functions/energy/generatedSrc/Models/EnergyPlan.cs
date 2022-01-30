/*
 * CDR Energy API
 *
 * Consumer Data Right end points and payloads for the Energy sector
 *
 * The version of the OpenAPI document: 1.15.0
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
using OpenAPIDateConverter = Agl.Cdr.Energy.Client.OpenAPIDateConverter;

namespace Agl.Cdr.Energy.Models
{
    /// <summary>
    /// EnergyPlan
    /// </summary>
    [DataContract(Name = "EnergyPlan")]
    public partial class EnergyPlan : IEquatable<EnergyPlan>, IValidatableObject
    {
        /// <summary>
        /// The type of the plan
        /// </summary>
        /// <value>The type of the plan</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum STANDING for value: STANDING
            /// </summary>
            [EnumMember(Value = "STANDING")]
            STANDING = 1,

            /// <summary>
            /// Enum MARKET for value: MARKET
            /// </summary>
            [EnumMember(Value = "MARKET")]
            MARKET = 2,

            /// <summary>
            /// Enum REGULATED for value: REGULATED
            /// </summary>
            [EnumMember(Value = "REGULATED")]
            REGULATED = 3

        }


        /// <summary>
        /// The type of the plan
        /// </summary>
        /// <value>The type of the plan</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// The fuel types covered by the plan
        /// </summary>
        /// <value>The fuel types covered by the plan</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FuelTypeEnum
        {
            /// <summary>
            /// Enum ELECTRICITY for value: ELECTRICITY
            /// </summary>
            [EnumMember(Value = "ELECTRICITY")]
            ELECTRICITY = 1,

            /// <summary>
            /// Enum GAS for value: GAS
            /// </summary>
            [EnumMember(Value = "GAS")]
            GAS = 2,

            /// <summary>
            /// Enum DUAL for value: DUAL
            /// </summary>
            [EnumMember(Value = "DUAL")]
            DUAL = 3

        }


        /// <summary>
        /// The fuel types covered by the plan
        /// </summary>
        /// <value>The fuel types covered by the plan</value>
        [DataMember(Name = "fuelType", IsRequired = true, EmitDefaultValue = false)]
        public FuelTypeEnum FuelType { get; set; }
        /// <summary>
        /// The type of customer that the plan is offered to.  If absent then the plan is available to all customers
        /// </summary>
        /// <value>The type of customer that the plan is offered to.  If absent then the plan is available to all customers</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CustomerTypeEnum
        {
            /// <summary>
            /// Enum RESIDENTIAL for value: RESIDENTIAL
            /// </summary>
            [EnumMember(Value = "RESIDENTIAL")]
            RESIDENTIAL = 1,

            /// <summary>
            /// Enum BUSINESS for value: BUSINESS
            /// </summary>
            [EnumMember(Value = "BUSINESS")]
            BUSINESS = 2

        }


        /// <summary>
        /// The type of customer that the plan is offered to.  If absent then the plan is available to all customers
        /// </summary>
        /// <value>The type of customer that the plan is offered to.  If absent then the plan is available to all customers</value>
        [DataMember(Name = "customerType", EmitDefaultValue = false)]
        public CustomerTypeEnum? CustomerType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyPlan" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnergyPlan() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyPlan" /> class.
        /// </summary>
        /// <param name="planId">The ID of the specific plan (required).</param>
        /// <param name="effectiveFrom">The date and time from which this plan is effective (ie. is available for origination). Used to enable the articulation of products to the regime before they are available for customers to originate.</param>
        /// <param name="effectiveTo">The date and time at which this plan will be retired and will no longer be offered. Used to enable the managed deprecation of plans.</param>
        /// <param name="lastUpdated">The last date and time that the information for this plan was changed (or the creation date for the plan if it has never been altered) (required).</param>
        /// <param name="displayName">The display name of the plan.</param>
        /// <param name="description">A description of the plan.</param>
        /// <param name="type">The type of the plan (required).</param>
        /// <param name="fuelType">The fuel types covered by the plan (required).</param>
        /// <param name="brand">The ID of the brand under which this plan is offered (required).</param>
        /// <param name="brandName">The display name of the brand under which this plan is offered (required).</param>
        /// <param name="applicationUri">A link to an application web page where this plan can be applied for.</param>
        /// <param name="additionalInformation">additionalInformation.</param>
        /// <param name="customerType">The type of customer that the plan is offered to.  If absent then the plan is available to all customers.</param>
        /// <param name="geography">geography.</param>
        public EnergyPlan(string planId = default(string), string effectiveFrom = default(string), string effectiveTo = default(string), string lastUpdated = default(string), string displayName = default(string), string description = default(string), TypeEnum type = default(TypeEnum), FuelTypeEnum fuelType = default(FuelTypeEnum), string brand = default(string), string brandName = default(string), string applicationUri = default(string), EnergyPlanAdditionalInformation additionalInformation = default(EnergyPlanAdditionalInformation), CustomerTypeEnum? customerType = default(CustomerTypeEnum?), EnergyPlanGeography geography = default(EnergyPlanGeography))
        {
            // to ensure "planId" is required (not null)
            this.PlanId = planId ?? throw new ArgumentNullException("planId is a required property for EnergyPlan and cannot be null");
            // to ensure "lastUpdated" is required (not null)
            this.LastUpdated = lastUpdated ?? throw new ArgumentNullException("lastUpdated is a required property for EnergyPlan and cannot be null");
            this.Type = type;
            this.FuelType = fuelType;
            // to ensure "brand" is required (not null)
            this.Brand = brand ?? throw new ArgumentNullException("brand is a required property for EnergyPlan and cannot be null");
            // to ensure "brandName" is required (not null)
            this.BrandName = brandName ?? throw new ArgumentNullException("brandName is a required property for EnergyPlan and cannot be null");
            this.EffectiveFrom = effectiveFrom;
            this.EffectiveTo = effectiveTo;
            this.DisplayName = displayName;
            this.Description = description;
            this.ApplicationUri = applicationUri;
            this.AdditionalInformation = additionalInformation;
            this.CustomerType = customerType;
            this.Geography = geography;
        }

        /// <summary>
        /// The ID of the specific plan
        /// </summary>
        /// <value>The ID of the specific plan</value>
        [DataMember(Name = "planId", IsRequired = true, EmitDefaultValue = false)]
        public string PlanId { get; set; }

        /// <summary>
        /// The date and time from which this plan is effective (ie. is available for origination). Used to enable the articulation of products to the regime before they are available for customers to originate
        /// </summary>
        /// <value>The date and time from which this plan is effective (ie. is available for origination). Used to enable the articulation of products to the regime before they are available for customers to originate</value>
        [DataMember(Name = "effectiveFrom", EmitDefaultValue = false)]
        public string EffectiveFrom { get; set; }

        /// <summary>
        /// The date and time at which this plan will be retired and will no longer be offered. Used to enable the managed deprecation of plans
        /// </summary>
        /// <value>The date and time at which this plan will be retired and will no longer be offered. Used to enable the managed deprecation of plans</value>
        [DataMember(Name = "effectiveTo", EmitDefaultValue = false)]
        public string EffectiveTo { get; set; }

        /// <summary>
        /// The last date and time that the information for this plan was changed (or the creation date for the plan if it has never been altered)
        /// </summary>
        /// <value>The last date and time that the information for this plan was changed (or the creation date for the plan if it has never been altered)</value>
        [DataMember(Name = "lastUpdated", IsRequired = true, EmitDefaultValue = false)]
        public string LastUpdated { get; set; }

        /// <summary>
        /// The display name of the plan
        /// </summary>
        /// <value>The display name of the plan</value>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// A description of the plan
        /// </summary>
        /// <value>A description of the plan</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the brand under which this plan is offered
        /// </summary>
        /// <value>The ID of the brand under which this plan is offered</value>
        [DataMember(Name = "brand", IsRequired = true, EmitDefaultValue = false)]
        public string Brand { get; set; }

        /// <summary>
        /// The display name of the brand under which this plan is offered
        /// </summary>
        /// <value>The display name of the brand under which this plan is offered</value>
        [DataMember(Name = "brandName", IsRequired = true, EmitDefaultValue = false)]
        public string BrandName { get; set; }

        /// <summary>
        /// A link to an application web page where this plan can be applied for
        /// </summary>
        /// <value>A link to an application web page where this plan can be applied for</value>
        [DataMember(Name = "applicationUri", EmitDefaultValue = false)]
        public string ApplicationUri { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalInformation
        /// </summary>
        [DataMember(Name = "additionalInformation", EmitDefaultValue = false)]
        public EnergyPlanAdditionalInformation AdditionalInformation { get; set; }

        /// <summary>
        /// Gets or Sets Geography
        /// </summary>
        [DataMember(Name = "geography", EmitDefaultValue = false)]
        public EnergyPlanGeography Geography { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyPlan {\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
            sb.Append("  EffectiveFrom: ").Append(EffectiveFrom).Append("\n");
            sb.Append("  EffectiveTo: ").Append(EffectiveTo).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FuelType: ").Append(FuelType).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  BrandName: ").Append(BrandName).Append("\n");
            sb.Append("  ApplicationUri: ").Append(ApplicationUri).Append("\n");
            sb.Append("  AdditionalInformation: ").Append(AdditionalInformation).Append("\n");
            sb.Append("  CustomerType: ").Append(CustomerType).Append("\n");
            sb.Append("  Geography: ").Append(Geography).Append("\n");
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
            return this.Equals(input as EnergyPlan);
        }

        /// <summary>
        /// Returns true if EnergyPlan instances are equal
        /// </summary>
        /// <param name="input">Instance of EnergyPlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyPlan input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PlanId == input.PlanId ||
                    (this.PlanId != null &&
                    this.PlanId.Equals(input.PlanId))
                ) && 
                (
                    this.EffectiveFrom == input.EffectiveFrom ||
                    (this.EffectiveFrom != null &&
                    this.EffectiveFrom.Equals(input.EffectiveFrom))
                ) && 
                (
                    this.EffectiveTo == input.EffectiveTo ||
                    (this.EffectiveTo != null &&
                    this.EffectiveTo.Equals(input.EffectiveTo))
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.FuelType == input.FuelType ||
                    this.FuelType.Equals(input.FuelType)
                ) && 
                (
                    this.Brand == input.Brand ||
                    (this.Brand != null &&
                    this.Brand.Equals(input.Brand))
                ) && 
                (
                    this.BrandName == input.BrandName ||
                    (this.BrandName != null &&
                    this.BrandName.Equals(input.BrandName))
                ) && 
                (
                    this.ApplicationUri == input.ApplicationUri ||
                    (this.ApplicationUri != null &&
                    this.ApplicationUri.Equals(input.ApplicationUri))
                ) && 
                (
                    this.AdditionalInformation == input.AdditionalInformation ||
                    (this.AdditionalInformation != null &&
                    this.AdditionalInformation.Equals(input.AdditionalInformation))
                ) && 
                (
                    this.CustomerType == input.CustomerType ||
                    this.CustomerType.Equals(input.CustomerType)
                ) && 
                (
                    this.Geography == input.Geography ||
                    (this.Geography != null &&
                    this.Geography.Equals(input.Geography))
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
                if (this.PlanId != null)
                    hashCode = hashCode * 59 + this.PlanId.GetHashCode();
                if (this.EffectiveFrom != null)
                    hashCode = hashCode * 59 + this.EffectiveFrom.GetHashCode();
                if (this.EffectiveTo != null)
                    hashCode = hashCode * 59 + this.EffectiveTo.GetHashCode();
                if (this.LastUpdated != null)
                    hashCode = hashCode * 59 + this.LastUpdated.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.FuelType.GetHashCode();
                if (this.Brand != null)
                    hashCode = hashCode * 59 + this.Brand.GetHashCode();
                if (this.BrandName != null)
                    hashCode = hashCode * 59 + this.BrandName.GetHashCode();
                if (this.ApplicationUri != null)
                    hashCode = hashCode * 59 + this.ApplicationUri.GetHashCode();
                if (this.AdditionalInformation != null)
                    hashCode = hashCode * 59 + this.AdditionalInformation.GetHashCode();
                hashCode = hashCode * 59 + this.CustomerType.GetHashCode();
                if (this.Geography != null)
                    hashCode = hashCode * 59 + this.Geography.GetHashCode();
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