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
    /// Object that contains links to additional information on specific topics
    /// </summary>
    [DataContract(Name = "EnergyPlan_additionalInformation")]
    public partial class EnergyPlanAdditionalInformation : IEquatable<EnergyPlanAdditionalInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyPlanAdditionalInformation" /> class.
        /// </summary>
        /// <param name="overviewUri">A link to a general overview of the plan.</param>
        /// <param name="termsUri">A link to terms and conditions for the plan.</param>
        /// <param name="eligibilityUri">A link to detail on eligibility criteria for the plan.</param>
        /// <param name="pricingUri">A link to detail on pricing for the plan.</param>
        /// <param name="bundleUri">A link to detail on bundles that this plan can be a part of.</param>
        public EnergyPlanAdditionalInformation(string overviewUri = default(string), string termsUri = default(string), string eligibilityUri = default(string), string pricingUri = default(string), string bundleUri = default(string))
        {
            this.OverviewUri = overviewUri;
            this.TermsUri = termsUri;
            this.EligibilityUri = eligibilityUri;
            this.PricingUri = pricingUri;
            this.BundleUri = bundleUri;
        }

        /// <summary>
        /// A link to a general overview of the plan
        /// </summary>
        /// <value>A link to a general overview of the plan</value>
        [DataMember(Name = "overviewUri", EmitDefaultValue = false)]
        public string OverviewUri { get; set; }

        /// <summary>
        /// A link to terms and conditions for the plan
        /// </summary>
        /// <value>A link to terms and conditions for the plan</value>
        [DataMember(Name = "termsUri", EmitDefaultValue = false)]
        public string TermsUri { get; set; }

        /// <summary>
        /// A link to detail on eligibility criteria for the plan
        /// </summary>
        /// <value>A link to detail on eligibility criteria for the plan</value>
        [DataMember(Name = "eligibilityUri", EmitDefaultValue = false)]
        public string EligibilityUri { get; set; }

        /// <summary>
        /// A link to detail on pricing for the plan
        /// </summary>
        /// <value>A link to detail on pricing for the plan</value>
        [DataMember(Name = "pricingUri", EmitDefaultValue = false)]
        public string PricingUri { get; set; }

        /// <summary>
        /// A link to detail on bundles that this plan can be a part of
        /// </summary>
        /// <value>A link to detail on bundles that this plan can be a part of</value>
        [DataMember(Name = "bundleUri", EmitDefaultValue = false)]
        public string BundleUri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyPlanAdditionalInformation {\n");
            sb.Append("  OverviewUri: ").Append(OverviewUri).Append("\n");
            sb.Append("  TermsUri: ").Append(TermsUri).Append("\n");
            sb.Append("  EligibilityUri: ").Append(EligibilityUri).Append("\n");
            sb.Append("  PricingUri: ").Append(PricingUri).Append("\n");
            sb.Append("  BundleUri: ").Append(BundleUri).Append("\n");
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
            return this.Equals(input as EnergyPlanAdditionalInformation);
        }

        /// <summary>
        /// Returns true if EnergyPlanAdditionalInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of EnergyPlanAdditionalInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyPlanAdditionalInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OverviewUri == input.OverviewUri ||
                    (this.OverviewUri != null &&
                    this.OverviewUri.Equals(input.OverviewUri))
                ) && 
                (
                    this.TermsUri == input.TermsUri ||
                    (this.TermsUri != null &&
                    this.TermsUri.Equals(input.TermsUri))
                ) && 
                (
                    this.EligibilityUri == input.EligibilityUri ||
                    (this.EligibilityUri != null &&
                    this.EligibilityUri.Equals(input.EligibilityUri))
                ) && 
                (
                    this.PricingUri == input.PricingUri ||
                    (this.PricingUri != null &&
                    this.PricingUri.Equals(input.PricingUri))
                ) && 
                (
                    this.BundleUri == input.BundleUri ||
                    (this.BundleUri != null &&
                    this.BundleUri.Equals(input.BundleUri))
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
                if (this.OverviewUri != null)
                    hashCode = hashCode * 59 + this.OverviewUri.GetHashCode();
                if (this.TermsUri != null)
                    hashCode = hashCode * 59 + this.TermsUri.GetHashCode();
                if (this.EligibilityUri != null)
                    hashCode = hashCode * 59 + this.EligibilityUri.GetHashCode();
                if (this.PricingUri != null)
                    hashCode = hashCode * 59 + this.PricingUri.GetHashCode();
                if (this.BundleUri != null)
                    hashCode = hashCode * 59 + this.BundleUri.GetHashCode();
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
