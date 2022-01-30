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
    /// EnergyAccountAllOfPlans
    /// </summary>
    [DataContract(Name = "EnergyAccount_allOf_plans")]
    public partial class EnergyAccountAllOfPlans : IEquatable<EnergyAccountAllOfPlans>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyAccountAllOfPlans" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnergyAccountAllOfPlans() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyAccountAllOfPlans" /> class.
        /// </summary>
        /// <param name="nickname">Optional display name for the plan provided by the customer to help differentiate multiple plans.</param>
        /// <param name="servicePointIds">An array of servicePointIds, representing NMIs, that this plan is linked to.  If there are no service points allocated to this plan then an empty array would be expected (required).</param>
        /// <param name="planOverview">planOverview (required).</param>
        public EnergyAccountAllOfPlans(string nickname = default(string), List<string> servicePointIds = default(List<string>), EnergyAccountAllOfPlanOverview planOverview = default(EnergyAccountAllOfPlanOverview))
        {
            // to ensure "servicePointIds" is required (not null)
            this.ServicePointIds = servicePointIds ?? throw new ArgumentNullException("servicePointIds is a required property for EnergyAccountAllOfPlans and cannot be null");
            // to ensure "planOverview" is required (not null)
            this.PlanOverview = planOverview ?? throw new ArgumentNullException("planOverview is a required property for EnergyAccountAllOfPlans and cannot be null");
            this.Nickname = nickname;
        }

        /// <summary>
        /// Optional display name for the plan provided by the customer to help differentiate multiple plans
        /// </summary>
        /// <value>Optional display name for the plan provided by the customer to help differentiate multiple plans</value>
        [DataMember(Name = "nickname", EmitDefaultValue = false)]
        public string Nickname { get; set; }

        /// <summary>
        /// An array of servicePointIds, representing NMIs, that this plan is linked to.  If there are no service points allocated to this plan then an empty array would be expected
        /// </summary>
        /// <value>An array of servicePointIds, representing NMIs, that this plan is linked to.  If there are no service points allocated to this plan then an empty array would be expected</value>
        [DataMember(Name = "servicePointIds", IsRequired = true, EmitDefaultValue = false)]
        public List<string> ServicePointIds { get; set; }

        /// <summary>
        /// Gets or Sets PlanOverview
        /// </summary>
        [DataMember(Name = "planOverview", IsRequired = true, EmitDefaultValue = false)]
        public EnergyAccountAllOfPlanOverview PlanOverview { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyAccountAllOfPlans {\n");
            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
            sb.Append("  ServicePointIds: ").Append(ServicePointIds).Append("\n");
            sb.Append("  PlanOverview: ").Append(PlanOverview).Append("\n");
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
            return this.Equals(input as EnergyAccountAllOfPlans);
        }

        /// <summary>
        /// Returns true if EnergyAccountAllOfPlans instances are equal
        /// </summary>
        /// <param name="input">Instance of EnergyAccountAllOfPlans to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyAccountAllOfPlans input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Nickname == input.Nickname ||
                    (this.Nickname != null &&
                    this.Nickname.Equals(input.Nickname))
                ) && 
                (
                    this.ServicePointIds == input.ServicePointIds ||
                    this.ServicePointIds != null &&
                    input.ServicePointIds != null &&
                    this.ServicePointIds.SequenceEqual(input.ServicePointIds)
                ) && 
                (
                    this.PlanOverview == input.PlanOverview ||
                    (this.PlanOverview != null &&
                    this.PlanOverview.Equals(input.PlanOverview))
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
                if (this.Nickname != null)
                    hashCode = hashCode * 59 + this.Nickname.GetHashCode();
                if (this.ServicePointIds != null)
                    hashCode = hashCode * 59 + this.ServicePointIds.GetHashCode();
                if (this.PlanOverview != null)
                    hashCode = hashCode * 59 + this.PlanOverview.GetHashCode();
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