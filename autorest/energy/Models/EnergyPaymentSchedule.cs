// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Agl.Cdr.Energy;

namespace Agl.Cdr.Energy.Models
{
    /// <summary> The EnergyPaymentSchedule. </summary>
    public partial class EnergyPaymentSchedule
    {
        /// <summary> Initializes a new instance of EnergyPaymentSchedule. </summary>
        /// <param name="paymentScheduleUType"> The type of object present in this response. </param>
        internal EnergyPaymentSchedule(EnergyPaymentScheduleUType paymentScheduleUType)
        {
            PaymentScheduleUType = paymentScheduleUType;
        }

        /// <summary> Initializes a new instance of EnergyPaymentSchedule. </summary>
        /// <param name="amount"> Optional payment amount indicating that a constant payment amount is scheduled to be paid (used in bill smooting scenarios). </param>
        /// <param name="paymentScheduleUType"> The type of object present in this response. </param>
        /// <param name="cardDebit"> Represents a regular credit card payment schedule. Mandatory if paymentScheduleUType is set to cardDebit. </param>
        /// <param name="directDebit"> Represents a regular direct debit from a specified bank account. Mandatory if paymentScheduleUType is set to directDebit. </param>
        /// <param name="manualPayment"> Represents a manual payment schedule where the customer pays in response to a delivered statement. Mandatory if paymentScheduleUType is set to manualPayment. </param>
        internal EnergyPaymentSchedule(string amount, EnergyPaymentScheduleUType paymentScheduleUType, EnergyPaymentScheduleCardDebit cardDebit, EnergyPaymentScheduleDirectDebit directDebit, EnergyPaymentScheduleManualPayment manualPayment)
        {
            Amount = amount;
            PaymentScheduleUType = paymentScheduleUType;
            CardDebit = cardDebit;
            DirectDebit = directDebit;
            ManualPayment = manualPayment;
        }

        /// <summary> Optional payment amount indicating that a constant payment amount is scheduled to be paid (used in bill smooting scenarios). </summary>
        public string Amount { get; }
        /// <summary> The type of object present in this response. </summary>
        public EnergyPaymentScheduleUType PaymentScheduleUType { get; }
        /// <summary> Represents a regular credit card payment schedule. Mandatory if paymentScheduleUType is set to cardDebit. </summary>
        public EnergyPaymentScheduleCardDebit CardDebit { get; }
        /// <summary> Represents a regular direct debit from a specified bank account. Mandatory if paymentScheduleUType is set to directDebit. </summary>
        public EnergyPaymentScheduleDirectDebit DirectDebit { get; }
        /// <summary> Represents a manual payment schedule where the customer pays in response to a delivered statement. Mandatory if paymentScheduleUType is set to manualPayment. </summary>
        public EnergyPaymentScheduleManualPayment ManualPayment { get; }
    }
}
