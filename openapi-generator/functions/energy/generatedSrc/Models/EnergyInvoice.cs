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
    /// EnergyInvoice
    /// </summary>
    [DataContract(Name = "EnergyInvoice")]
    public partial class EnergyInvoice : IEquatable<EnergyInvoice>, IValidatableObject
    {
        /// <summary>
        /// Indicator of the payment status for the invoice
        /// </summary>
        /// <value>Indicator of the payment status for the invoice</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentStatusEnum
        {
            /// <summary>
            /// Enum PAID for value: PAID
            /// </summary>
            [EnumMember(Value = "PAID")]
            PAID = 1,

            /// <summary>
            /// Enum PARTIALLYPAID for value: PARTIALLY_PAID
            /// </summary>
            [EnumMember(Value = "PARTIALLY_PAID")]
            PARTIALLYPAID = 2,

            /// <summary>
            /// Enum NOTPAID for value: NOT_PAID
            /// </summary>
            [EnumMember(Value = "NOT_PAID")]
            NOTPAID = 3

        }


        /// <summary>
        /// Indicator of the payment status for the invoice
        /// </summary>
        /// <value>Indicator of the payment status for the invoice</value>
        [DataMember(Name = "paymentStatus", IsRequired = true, EmitDefaultValue = false)]
        public PaymentStatusEnum PaymentStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyInvoice" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnergyInvoice() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyInvoice" /> class.
        /// </summary>
        /// <param name="accountId">The ID of the account for which the invoice was issued (required).</param>
        /// <param name="invoiceNumber">The number assigned to this invoice by the energy Retailer (required).</param>
        /// <param name="issueDate">The date that the invoice was actually issued (as opposed to generated or calculated) (required).</param>
        /// <param name="dueDate">The date that the invoice is due to be paid.</param>
        /// <param name="period">period.</param>
        /// <param name="invoiceAmount">The net amount due for this invoice regardless of previous balance.</param>
        /// <param name="gstAmount">The total GST amount for this invoice.  If absent then zero is assumed.</param>
        /// <param name="payOnTimeDiscount">payOnTimeDiscount.</param>
        /// <param name="balanceAtIssue">The account balance at the time the invoice was issued (required).</param>
        /// <param name="servicePoints">Array of service point IDs to which this invoice applies. May be empty if the invoice contains no electricity usage related charges (required).</param>
        /// <param name="gas">gas.</param>
        /// <param name="electricity">electricity.</param>
        /// <param name="accountCharges">accountCharges.</param>
        /// <param name="paymentStatus">Indicator of the payment status for the invoice (required).</param>
        public EnergyInvoice(string accountId = default(string), string invoiceNumber = default(string), string issueDate = default(string), string dueDate = default(string), EnergyInvoicePeriod period = default(EnergyInvoicePeriod), string invoiceAmount = default(string), string gstAmount = default(string), EnergyInvoicePayOnTimeDiscount payOnTimeDiscount = default(EnergyInvoicePayOnTimeDiscount), string balanceAtIssue = default(string), List<string> servicePoints = default(List<string>), EnergyInvoiceGasUsageCharges gas = default(EnergyInvoiceGasUsageCharges), EnergyInvoiceElectricityUsageCharges electricity = default(EnergyInvoiceElectricityUsageCharges), EnergyInvoiceAccountCharges accountCharges = default(EnergyInvoiceAccountCharges), PaymentStatusEnum paymentStatus = default(PaymentStatusEnum))
        {
            // to ensure "accountId" is required (not null)
            this.AccountId = accountId ?? throw new ArgumentNullException("accountId is a required property for EnergyInvoice and cannot be null");
            // to ensure "invoiceNumber" is required (not null)
            this.InvoiceNumber = invoiceNumber ?? throw new ArgumentNullException("invoiceNumber is a required property for EnergyInvoice and cannot be null");
            // to ensure "issueDate" is required (not null)
            this.IssueDate = issueDate ?? throw new ArgumentNullException("issueDate is a required property for EnergyInvoice and cannot be null");
            // to ensure "balanceAtIssue" is required (not null)
            this.BalanceAtIssue = balanceAtIssue ?? throw new ArgumentNullException("balanceAtIssue is a required property for EnergyInvoice and cannot be null");
            // to ensure "servicePoints" is required (not null)
            this.ServicePoints = servicePoints ?? throw new ArgumentNullException("servicePoints is a required property for EnergyInvoice and cannot be null");
            this.PaymentStatus = paymentStatus;
            this.DueDate = dueDate;
            this.Period = period;
            this.InvoiceAmount = invoiceAmount;
            this.GstAmount = gstAmount;
            this.PayOnTimeDiscount = payOnTimeDiscount;
            this.Gas = gas;
            this.Electricity = electricity;
            this.AccountCharges = accountCharges;
        }

        /// <summary>
        /// The ID of the account for which the invoice was issued
        /// </summary>
        /// <value>The ID of the account for which the invoice was issued</value>
        [DataMember(Name = "accountId", IsRequired = true, EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The number assigned to this invoice by the energy Retailer
        /// </summary>
        /// <value>The number assigned to this invoice by the energy Retailer</value>
        [DataMember(Name = "invoiceNumber", IsRequired = true, EmitDefaultValue = false)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// The date that the invoice was actually issued (as opposed to generated or calculated)
        /// </summary>
        /// <value>The date that the invoice was actually issued (as opposed to generated or calculated)</value>
        [DataMember(Name = "issueDate", IsRequired = true, EmitDefaultValue = false)]
        public string IssueDate { get; set; }

        /// <summary>
        /// The date that the invoice is due to be paid
        /// </summary>
        /// <value>The date that the invoice is due to be paid</value>
        [DataMember(Name = "dueDate", EmitDefaultValue = false)]
        public string DueDate { get; set; }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name = "period", EmitDefaultValue = false)]
        public EnergyInvoicePeriod Period { get; set; }

        /// <summary>
        /// The net amount due for this invoice regardless of previous balance
        /// </summary>
        /// <value>The net amount due for this invoice regardless of previous balance</value>
        [DataMember(Name = "invoiceAmount", EmitDefaultValue = false)]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// The total GST amount for this invoice.  If absent then zero is assumed
        /// </summary>
        /// <value>The total GST amount for this invoice.  If absent then zero is assumed</value>
        [DataMember(Name = "gstAmount", EmitDefaultValue = false)]
        public string GstAmount { get; set; }

        /// <summary>
        /// Gets or Sets PayOnTimeDiscount
        /// </summary>
        [DataMember(Name = "payOnTimeDiscount", EmitDefaultValue = false)]
        public EnergyInvoicePayOnTimeDiscount PayOnTimeDiscount { get; set; }

        /// <summary>
        /// The account balance at the time the invoice was issued
        /// </summary>
        /// <value>The account balance at the time the invoice was issued</value>
        [DataMember(Name = "balanceAtIssue", IsRequired = true, EmitDefaultValue = false)]
        public string BalanceAtIssue { get; set; }

        /// <summary>
        /// Array of service point IDs to which this invoice applies. May be empty if the invoice contains no electricity usage related charges
        /// </summary>
        /// <value>Array of service point IDs to which this invoice applies. May be empty if the invoice contains no electricity usage related charges</value>
        [DataMember(Name = "servicePoints", IsRequired = true, EmitDefaultValue = false)]
        public List<string> ServicePoints { get; set; }

        /// <summary>
        /// Gets or Sets Gas
        /// </summary>
        [DataMember(Name = "gas", EmitDefaultValue = false)]
        public EnergyInvoiceGasUsageCharges Gas { get; set; }

        /// <summary>
        /// Gets or Sets Electricity
        /// </summary>
        [DataMember(Name = "electricity", EmitDefaultValue = false)]
        public EnergyInvoiceElectricityUsageCharges Electricity { get; set; }

        /// <summary>
        /// Gets or Sets AccountCharges
        /// </summary>
        [DataMember(Name = "accountCharges", EmitDefaultValue = false)]
        public EnergyInvoiceAccountCharges AccountCharges { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyInvoice {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  IssueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  InvoiceAmount: ").Append(InvoiceAmount).Append("\n");
            sb.Append("  GstAmount: ").Append(GstAmount).Append("\n");
            sb.Append("  PayOnTimeDiscount: ").Append(PayOnTimeDiscount).Append("\n");
            sb.Append("  BalanceAtIssue: ").Append(BalanceAtIssue).Append("\n");
            sb.Append("  ServicePoints: ").Append(ServicePoints).Append("\n");
            sb.Append("  Gas: ").Append(Gas).Append("\n");
            sb.Append("  Electricity: ").Append(Electricity).Append("\n");
            sb.Append("  AccountCharges: ").Append(AccountCharges).Append("\n");
            sb.Append("  PaymentStatus: ").Append(PaymentStatus).Append("\n");
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
            return this.Equals(input as EnergyInvoice);
        }

        /// <summary>
        /// Returns true if EnergyInvoice instances are equal
        /// </summary>
        /// <param name="input">Instance of EnergyInvoice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyInvoice input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.InvoiceNumber == input.InvoiceNumber ||
                    (this.InvoiceNumber != null &&
                    this.InvoiceNumber.Equals(input.InvoiceNumber))
                ) && 
                (
                    this.IssueDate == input.IssueDate ||
                    (this.IssueDate != null &&
                    this.IssueDate.Equals(input.IssueDate))
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.InvoiceAmount == input.InvoiceAmount ||
                    (this.InvoiceAmount != null &&
                    this.InvoiceAmount.Equals(input.InvoiceAmount))
                ) && 
                (
                    this.GstAmount == input.GstAmount ||
                    (this.GstAmount != null &&
                    this.GstAmount.Equals(input.GstAmount))
                ) && 
                (
                    this.PayOnTimeDiscount == input.PayOnTimeDiscount ||
                    (this.PayOnTimeDiscount != null &&
                    this.PayOnTimeDiscount.Equals(input.PayOnTimeDiscount))
                ) && 
                (
                    this.BalanceAtIssue == input.BalanceAtIssue ||
                    (this.BalanceAtIssue != null &&
                    this.BalanceAtIssue.Equals(input.BalanceAtIssue))
                ) && 
                (
                    this.ServicePoints == input.ServicePoints ||
                    this.ServicePoints != null &&
                    input.ServicePoints != null &&
                    this.ServicePoints.SequenceEqual(input.ServicePoints)
                ) && 
                (
                    this.Gas == input.Gas ||
                    (this.Gas != null &&
                    this.Gas.Equals(input.Gas))
                ) && 
                (
                    this.Electricity == input.Electricity ||
                    (this.Electricity != null &&
                    this.Electricity.Equals(input.Electricity))
                ) && 
                (
                    this.AccountCharges == input.AccountCharges ||
                    (this.AccountCharges != null &&
                    this.AccountCharges.Equals(input.AccountCharges))
                ) && 
                (
                    this.PaymentStatus == input.PaymentStatus ||
                    this.PaymentStatus.Equals(input.PaymentStatus)
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
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.InvoiceNumber != null)
                    hashCode = hashCode * 59 + this.InvoiceNumber.GetHashCode();
                if (this.IssueDate != null)
                    hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.DueDate != null)
                    hashCode = hashCode * 59 + this.DueDate.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.InvoiceAmount != null)
                    hashCode = hashCode * 59 + this.InvoiceAmount.GetHashCode();
                if (this.GstAmount != null)
                    hashCode = hashCode * 59 + this.GstAmount.GetHashCode();
                if (this.PayOnTimeDiscount != null)
                    hashCode = hashCode * 59 + this.PayOnTimeDiscount.GetHashCode();
                if (this.BalanceAtIssue != null)
                    hashCode = hashCode * 59 + this.BalanceAtIssue.GetHashCode();
                if (this.ServicePoints != null)
                    hashCode = hashCode * 59 + this.ServicePoints.GetHashCode();
                if (this.Gas != null)
                    hashCode = hashCode * 59 + this.Gas.GetHashCode();
                if (this.Electricity != null)
                    hashCode = hashCode * 59 + this.Electricity.GetHashCode();
                if (this.AccountCharges != null)
                    hashCode = hashCode * 59 + this.AccountCharges.GetHashCode();
                hashCode = hashCode * 59 + this.PaymentStatus.GetHashCode();
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
