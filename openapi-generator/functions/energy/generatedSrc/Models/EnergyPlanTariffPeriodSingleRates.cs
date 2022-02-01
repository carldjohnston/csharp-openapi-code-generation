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
    /// EnergyPlanTariffPeriodSingleRates
    /// </summary>
    [DataContract(Name = "EnergyPlanTariffPeriod_single_rates")]
    public partial class EnergyPlanTariffPeriodSingleRates : IEquatable<EnergyPlanTariffPeriodSingleRates>, IValidatableObject
    {
        /// <summary>
        /// The measurement unit of rate. Assumed to be KWH if absent
        /// </summary>
        /// <value>The measurement unit of rate. Assumed to be KWH if absent</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MeasureUnitEnum
        {
            /// <summary>
            /// Enum KWH for value: KWH
            /// </summary>
            [EnumMember(Value = "KWH")]
            KWH = 1,

            /// <summary>
            /// Enum KVA for value: KVA
            /// </summary>
            [EnumMember(Value = "KVA")]
            KVA = 2,

            /// <summary>
            /// Enum KVAR for value: KVAR
            /// </summary>
            [EnumMember(Value = "KVAR")]
            KVAR = 3,

            /// <summary>
            /// Enum KVARH for value: KVARH
            /// </summary>
            [EnumMember(Value = "KVARH")]
            KVARH = 4,

            /// <summary>
            /// Enum KW for value: KW
            /// </summary>
            [EnumMember(Value = "KW")]
            KW = 5,

            /// <summary>
            /// Enum DAYS for value: DAYS
            /// </summary>
            [EnumMember(Value = "DAYS")]
            DAYS = 6,

            /// <summary>
            /// Enum METER for value: METER
            /// </summary>
            [EnumMember(Value = "METER")]
            METER = 7,

            /// <summary>
            /// Enum MONTH for value: MONTH
            /// </summary>
            [EnumMember(Value = "MONTH")]
            MONTH = 8

        }


        /// <summary>
        /// The measurement unit of rate. Assumed to be KWH if absent
        /// </summary>
        /// <value>The measurement unit of rate. Assumed to be KWH if absent</value>
        [DataMember(Name = "measureUnit", EmitDefaultValue = false)]
        public MeasureUnitEnum? MeasureUnit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyPlanTariffPeriodSingleRates" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnergyPlanTariffPeriodSingleRates() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyPlanTariffPeriodSingleRates" /> class.
        /// </summary>
        /// <param name="unitPrice">Unit price of usage per measure unit (exclusive of GST) (required).</param>
        /// <param name="measureUnit">The measurement unit of rate. Assumed to be KWH if absent.</param>
        /// <param name="volume">Volume in kWh that this rate applies to.  Only applicable for ‘stepped’ rates where different rates apply for different volumes of usage in a period.</param>
        public EnergyPlanTariffPeriodSingleRates(string unitPrice = default(string), MeasureUnitEnum? measureUnit = default(MeasureUnitEnum?), decimal volume = default(decimal))
        {
            // to ensure "unitPrice" is required (not null)
            this.UnitPrice = unitPrice ?? throw new ArgumentNullException("unitPrice is a required property for EnergyPlanTariffPeriodSingleRates and cannot be null");
            this.MeasureUnit = measureUnit;
            this.Volume = volume;
        }

        /// <summary>
        /// Unit price of usage per measure unit (exclusive of GST)
        /// </summary>
        /// <value>Unit price of usage per measure unit (exclusive of GST)</value>
        [DataMember(Name = "unitPrice", IsRequired = true, EmitDefaultValue = false)]
        public string UnitPrice { get; set; }

        /// <summary>
        /// Volume in kWh that this rate applies to.  Only applicable for ‘stepped’ rates where different rates apply for different volumes of usage in a period
        /// </summary>
        /// <value>Volume in kWh that this rate applies to.  Only applicable for ‘stepped’ rates where different rates apply for different volumes of usage in a period</value>
        [DataMember(Name = "volume", EmitDefaultValue = false)]
        public decimal Volume { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyPlanTariffPeriodSingleRates {\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  MeasureUnit: ").Append(MeasureUnit).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
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
            return this.Equals(input as EnergyPlanTariffPeriodSingleRates);
        }

        /// <summary>
        /// Returns true if EnergyPlanTariffPeriodSingleRates instances are equal
        /// </summary>
        /// <param name="input">Instance of EnergyPlanTariffPeriodSingleRates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyPlanTariffPeriodSingleRates input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UnitPrice == input.UnitPrice ||
                    (this.UnitPrice != null &&
                    this.UnitPrice.Equals(input.UnitPrice))
                ) && 
                (
                    this.MeasureUnit == input.MeasureUnit ||
                    this.MeasureUnit.Equals(input.MeasureUnit)
                ) && 
                (
                    this.Volume == input.Volume ||
                    this.Volume.Equals(input.Volume)
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
                if (this.UnitPrice != null)
                    hashCode = hashCode * 59 + this.UnitPrice.GetHashCode();
                hashCode = hashCode * 59 + this.MeasureUnit.GetHashCode();
                hashCode = hashCode * 59 + this.Volume.GetHashCode();
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