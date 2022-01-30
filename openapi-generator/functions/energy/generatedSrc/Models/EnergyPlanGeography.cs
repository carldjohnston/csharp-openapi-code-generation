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
    /// Describes the geographical area that the plan is available for.  If absent then it is assumed the plan is not geographically limited
    /// </summary>
    [DataContract(Name = "EnergyPlan_geography")]
    public partial class EnergyPlanGeography : IEquatable<EnergyPlanGeography>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyPlanGeography" /> class.
        /// </summary>
        /// <param name="excludedPostcodes">Array of valid Australian post codes that are specifically excluded from the plan.  Each element is a single four digit postcode (e.g. 3000) or a range of postcodes defined by two four digit postcodes and a hyphen (e.g. 3000-3999).</param>
        /// <param name="includedPostcodes">Array of valid Australian post codes that are included from the plan.  If absent defaults to all non-excluded post codes.  Each element is a single four digit postcode (e.g. 3000) or a range of postcodes defined by two four digit postcodes and a hyphen (e.g. 3000-3999).</param>
        public EnergyPlanGeography(List<string> excludedPostcodes = default(List<string>), List<string> includedPostcodes = default(List<string>))
        {
            this.ExcludedPostcodes = excludedPostcodes;
            this.IncludedPostcodes = includedPostcodes;
        }

        /// <summary>
        /// Array of valid Australian post codes that are specifically excluded from the plan.  Each element is a single four digit postcode (e.g. 3000) or a range of postcodes defined by two four digit postcodes and a hyphen (e.g. 3000-3999)
        /// </summary>
        /// <value>Array of valid Australian post codes that are specifically excluded from the plan.  Each element is a single four digit postcode (e.g. 3000) or a range of postcodes defined by two four digit postcodes and a hyphen (e.g. 3000-3999)</value>
        [DataMember(Name = "excludedPostcodes", EmitDefaultValue = false)]
        public List<string> ExcludedPostcodes { get; set; }

        /// <summary>
        /// Array of valid Australian post codes that are included from the plan.  If absent defaults to all non-excluded post codes.  Each element is a single four digit postcode (e.g. 3000) or a range of postcodes defined by two four digit postcodes and a hyphen (e.g. 3000-3999)
        /// </summary>
        /// <value>Array of valid Australian post codes that are included from the plan.  If absent defaults to all non-excluded post codes.  Each element is a single four digit postcode (e.g. 3000) or a range of postcodes defined by two four digit postcodes and a hyphen (e.g. 3000-3999)</value>
        [DataMember(Name = "includedPostcodes", EmitDefaultValue = false)]
        public List<string> IncludedPostcodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyPlanGeography {\n");
            sb.Append("  ExcludedPostcodes: ").Append(ExcludedPostcodes).Append("\n");
            sb.Append("  IncludedPostcodes: ").Append(IncludedPostcodes).Append("\n");
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
            return this.Equals(input as EnergyPlanGeography);
        }

        /// <summary>
        /// Returns true if EnergyPlanGeography instances are equal
        /// </summary>
        /// <param name="input">Instance of EnergyPlanGeography to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyPlanGeography input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExcludedPostcodes == input.ExcludedPostcodes ||
                    this.ExcludedPostcodes != null &&
                    input.ExcludedPostcodes != null &&
                    this.ExcludedPostcodes.SequenceEqual(input.ExcludedPostcodes)
                ) && 
                (
                    this.IncludedPostcodes == input.IncludedPostcodes ||
                    this.IncludedPostcodes != null &&
                    input.IncludedPostcodes != null &&
                    this.IncludedPostcodes.SequenceEqual(input.IncludedPostcodes)
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
                if (this.ExcludedPostcodes != null)
                    hashCode = hashCode * 59 + this.ExcludedPostcodes.GetHashCode();
                if (this.IncludedPostcodes != null)
                    hashCode = hashCode * 59 + this.IncludedPostcodes.GetHashCode();
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
