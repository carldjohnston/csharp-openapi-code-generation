// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Agl.Cdr.Energy;

namespace Agl.Cdr.Energy.Models
{
    /// <summary> The EnergyInvoice. </summary>
    public partial class EnergyInvoice
    {
        /// <summary> Initializes a new instance of EnergyInvoice. </summary>
        /// <param name="accountId"> The ID of the account for which the invoice was issued. </param>
        /// <param name="invoiceNumber"> The number assigned to this invoice by the energy Retailer. </param>
        /// <param name="issueDate"> The date that the invoice was actually issued (as opposed to generated or calculated). </param>
        /// <param name="balanceAtIssue"> The account balance at the time the invoice was issued. </param>
        /// <param name="servicePoints"> Array of service point IDs to which this invoice applies. May be empty if the invoice contains no electricity usage related charges. </param>
        /// <param name="paymentStatus"> Indicator of the payment status for the invoice. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountId"/>, <paramref name="invoiceNumber"/>, <paramref name="issueDate"/>, <paramref name="balanceAtIssue"/>, or <paramref name="servicePoints"/> is null. </exception>
        internal EnergyInvoice(string accountId, string invoiceNumber, string issueDate, string balanceAtIssue, List<string> servicePoints, EnergyInvoicePaymentStatus paymentStatus)
        {
            if (accountId == null)
            {
                throw new ArgumentNullException(nameof(accountId));
            }
            if (invoiceNumber == null)
            {
                throw new ArgumentNullException(nameof(invoiceNumber));
            }
            if (issueDate == null)
            {
                throw new ArgumentNullException(nameof(issueDate));
            }
            if (balanceAtIssue == null)
            {
                throw new ArgumentNullException(nameof(balanceAtIssue));
            }
            if (servicePoints == null)
            {
                throw new ArgumentNullException(nameof(servicePoints));
            }

            AccountId = accountId;
            InvoiceNumber = invoiceNumber;
            IssueDate = issueDate;
            BalanceAtIssue = balanceAtIssue;
            ServicePoints = servicePoints;
            PaymentStatus = paymentStatus;
        }

        /// <summary> Initializes a new instance of EnergyInvoice. </summary>
        /// <param name="accountId"> The ID of the account for which the invoice was issued. </param>
        /// <param name="invoiceNumber"> The number assigned to this invoice by the energy Retailer. </param>
        /// <param name="issueDate"> The date that the invoice was actually issued (as opposed to generated or calculated). </param>
        /// <param name="dueDate"> The date that the invoice is due to be paid. </param>
        /// <param name="period"> Object containing the start and end date for the period covered by the invoice.  Mandatory if any usage or demand based charges are included in the invoice. </param>
        /// <param name="invoiceAmount"> The net amount due for this invoice regardless of previous balance. </param>
        /// <param name="gstAmount"> The total GST amount for this invoice.  If absent then zero is assumed. </param>
        /// <param name="payOnTimeDiscount"> A discount for on time payment. </param>
        /// <param name="balanceAtIssue"> The account balance at the time the invoice was issued. </param>
        /// <param name="servicePoints"> Array of service point IDs to which this invoice applies. May be empty if the invoice contains no electricity usage related charges. </param>
        /// <param name="gas"> . </param>
        /// <param name="electricity"> . </param>
        /// <param name="accountCharges"> Object contain charges and credits related to electricity usage. </param>
        /// <param name="paymentStatus"> Indicator of the payment status for the invoice. </param>
        internal EnergyInvoice(string accountId, string invoiceNumber, string issueDate, string dueDate, EnergyInvoicePeriod period, string invoiceAmount, string gstAmount, EnergyInvoicePayOnTimeDiscount payOnTimeDiscount, string balanceAtIssue, IReadOnlyList<string> servicePoints, EnergyInvoiceGasUsageCharges gas, EnergyInvoiceElectricityUsageCharges electricity, EnergyInvoiceAccountCharges accountCharges, EnergyInvoicePaymentStatus paymentStatus)
        {
            AccountId = accountId;
            InvoiceNumber = invoiceNumber;
            IssueDate = issueDate;
            DueDate = dueDate;
            Period = period;
            InvoiceAmount = invoiceAmount;
            GstAmount = gstAmount;
            PayOnTimeDiscount = payOnTimeDiscount;
            BalanceAtIssue = balanceAtIssue;
            ServicePoints = servicePoints;
            Gas = gas;
            Electricity = electricity;
            AccountCharges = accountCharges;
            PaymentStatus = paymentStatus;
        }

        /// <summary> The ID of the account for which the invoice was issued. </summary>
        public string AccountId { get; }
        /// <summary> The number assigned to this invoice by the energy Retailer. </summary>
        public string InvoiceNumber { get; }
        /// <summary> The date that the invoice was actually issued (as opposed to generated or calculated). </summary>
        public string IssueDate { get; }
        /// <summary> The date that the invoice is due to be paid. </summary>
        public string DueDate { get; }
        /// <summary> Object containing the start and end date for the period covered by the invoice.  Mandatory if any usage or demand based charges are included in the invoice. </summary>
        public EnergyInvoicePeriod Period { get; }
        /// <summary> The net amount due for this invoice regardless of previous balance. </summary>
        public string InvoiceAmount { get; }
        /// <summary> The total GST amount for this invoice.  If absent then zero is assumed. </summary>
        public string GstAmount { get; }
        /// <summary> A discount for on time payment. </summary>
        public EnergyInvoicePayOnTimeDiscount PayOnTimeDiscount { get; }
        /// <summary> The account balance at the time the invoice was issued. </summary>
        public string BalanceAtIssue { get; }
        /// <summary> Array of service point IDs to which this invoice applies. May be empty if the invoice contains no electricity usage related charges. </summary>
        public IReadOnlyList<string> ServicePoints { get; }
        public EnergyInvoiceGasUsageCharges Gas { get; }
        public EnergyInvoiceElectricityUsageCharges Electricity { get; }
        /// <summary> Object contain charges and credits related to electricity usage. </summary>
        public EnergyInvoiceAccountCharges AccountCharges { get; }
        /// <summary> Indicator of the payment status for the invoice. </summary>
        public EnergyInvoicePaymentStatus PaymentStatus { get; }
    }
}
