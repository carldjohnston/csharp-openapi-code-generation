// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Agl.Cdr.Energy;

namespace Agl.Cdr.Energy.Models
{
    /// <summary> The EnergyBillingUsageTransaction. </summary>
    public partial class EnergyBillingUsageTransaction
    {
        /// <summary> Initializes a new instance of EnergyBillingUsageTransaction. </summary>
        /// <param name="timeOfUseType"> The time of use type that the transaction applies to. </param>
        /// <param name="startDate"> Date and time when the usage period starts. </param>
        /// <param name="endDate"> Date and time when the usage period ends. </param>
        /// <param name="usage"> The usage for the period in measure unit.  A negative value indicates power generated. </param>
        /// <param name="amount"> The amount charged or credited for this transaction prior to any adjustments being applied.  A negative value indicates a credit. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="startDate"/>, <paramref name="endDate"/>, or <paramref name="amount"/> is null. </exception>
        internal EnergyBillingUsageTransaction(EnergyBillingUsageTransactionTimeOfUseType timeOfUseType, string startDate, string endDate, float usage, string amount)
        {
            if (startDate == null)
            {
                throw new ArgumentNullException(nameof(startDate));
            }
            if (endDate == null)
            {
                throw new ArgumentNullException(nameof(endDate));
            }
            if (amount == null)
            {
                throw new ArgumentNullException(nameof(amount));
            }

            TimeOfUseType = timeOfUseType;
            StartDate = startDate;
            EndDate = endDate;
            Usage = usage;
            Amount = amount;
            CalculationFactors = new List<EnergyBillingUsageTransactionCalculationFactors>();
            Adjustments = new List<EnergyBillingUsageTransactionAdjustments>();
        }

        /// <summary> Initializes a new instance of EnergyBillingUsageTransaction. </summary>
        /// <param name="servicePointId"> The ID of the service point to which this transaction applies if any. </param>
        /// <param name="invoiceNumber"> The number of the invoice in which this transaction is included if it has been issued. </param>
        /// <param name="timeOfUseType"> The time of use type that the transaction applies to. </param>
        /// <param name="description"> Optional description of the transaction that can be used for display purposes. </param>
        /// <param name="isEstimate"> Flag indicating if the usage is estimated or actual.  True indicates estimate.  False or absent indicates actual. </param>
        /// <param name="startDate"> Date and time when the usage period starts. </param>
        /// <param name="endDate"> Date and time when the usage period ends. </param>
        /// <param name="measureUnit"> The measurement unit of rate. Assumed to be KWH if absent. </param>
        /// <param name="usage"> The usage for the period in measure unit.  A negative value indicates power generated. </param>
        /// <param name="amount"> The amount charged or credited for this transaction prior to any adjustments being applied.  A negative value indicates a credit. </param>
        /// <param name="calculationFactors"> Additional calculation factors that inform the transaction. </param>
        /// <param name="adjustments"> Optional array of adjustments arising for this transaction. </param>
        internal EnergyBillingUsageTransaction(string servicePointId, string invoiceNumber, EnergyBillingUsageTransactionTimeOfUseType timeOfUseType, string description, bool? isEstimate, string startDate, string endDate, EnergyBillingUsageTransactionMeasureUnit? measureUnit, float usage, string amount, IReadOnlyList<EnergyBillingUsageTransactionCalculationFactors> calculationFactors, IReadOnlyList<EnergyBillingUsageTransactionAdjustments> adjustments)
        {
            ServicePointId = servicePointId;
            InvoiceNumber = invoiceNumber;
            TimeOfUseType = timeOfUseType;
            Description = description;
            IsEstimate = isEstimate;
            StartDate = startDate;
            EndDate = endDate;
            MeasureUnit = measureUnit;
            Usage = usage;
            Amount = amount;
            CalculationFactors = calculationFactors;
            Adjustments = adjustments;
        }

        /// <summary> The ID of the service point to which this transaction applies if any. </summary>
        public string ServicePointId { get; }
        /// <summary> The number of the invoice in which this transaction is included if it has been issued. </summary>
        public string InvoiceNumber { get; }
        /// <summary> The time of use type that the transaction applies to. </summary>
        public EnergyBillingUsageTransactionTimeOfUseType TimeOfUseType { get; }
        /// <summary> Optional description of the transaction that can be used for display purposes. </summary>
        public string Description { get; }
        /// <summary> Flag indicating if the usage is estimated or actual.  True indicates estimate.  False or absent indicates actual. </summary>
        public bool? IsEstimate { get; }
        /// <summary> Date and time when the usage period starts. </summary>
        public string StartDate { get; }
        /// <summary> Date and time when the usage period ends. </summary>
        public string EndDate { get; }
        /// <summary> The measurement unit of rate. Assumed to be KWH if absent. </summary>
        public EnergyBillingUsageTransactionMeasureUnit? MeasureUnit { get; }
        /// <summary> The usage for the period in measure unit.  A negative value indicates power generated. </summary>
        public float Usage { get; }
        /// <summary> The amount charged or credited for this transaction prior to any adjustments being applied.  A negative value indicates a credit. </summary>
        public string Amount { get; }
        /// <summary> Additional calculation factors that inform the transaction. </summary>
        public IReadOnlyList<EnergyBillingUsageTransactionCalculationFactors> CalculationFactors { get; }
        /// <summary> Optional array of adjustments arising for this transaction. </summary>
        public IReadOnlyList<EnergyBillingUsageTransactionAdjustments> Adjustments { get; }
    }
}
