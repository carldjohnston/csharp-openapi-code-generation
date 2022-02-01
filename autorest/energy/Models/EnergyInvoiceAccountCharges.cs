// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Agl.Cdr.Energy.Models
{
    /// <summary> Object contain charges and credits related to electricity usage. </summary>
    public partial class EnergyInvoiceAccountCharges
    {
        /// <summary> Initializes a new instance of EnergyInvoiceAccountCharges. </summary>
        /// <param name="totalCharges"> The aggregate total of account level charges for the period covered by the invoice. </param>
        /// <param name="totalDiscounts"> The aggregate total of account level discounts or credits for the period covered by the invoice. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="totalCharges"/> or <paramref name="totalDiscounts"/> is null. </exception>
        internal EnergyInvoiceAccountCharges(string totalCharges, string totalDiscounts)
        {
            if (totalCharges == null)
            {
                throw new ArgumentNullException(nameof(totalCharges));
            }
            if (totalDiscounts == null)
            {
                throw new ArgumentNullException(nameof(totalDiscounts));
            }

            TotalCharges = totalCharges;
            TotalDiscounts = totalDiscounts;
        }

        /// <summary> Initializes a new instance of EnergyInvoiceAccountCharges. </summary>
        /// <param name="totalCharges"> The aggregate total of account level charges for the period covered by the invoice. </param>
        /// <param name="totalDiscounts"> The aggregate total of account level discounts or credits for the period covered by the invoice. </param>
        /// <param name="totalGst"> The total GST for all account level charges.  If absent then zero is assumed. </param>
        internal EnergyInvoiceAccountCharges(string totalCharges, string totalDiscounts, string totalGst)
        {
            TotalCharges = totalCharges;
            TotalDiscounts = totalDiscounts;
            TotalGst = totalGst;
        }

        /// <summary> The aggregate total of account level charges for the period covered by the invoice. </summary>
        public string TotalCharges { get; }
        /// <summary> The aggregate total of account level discounts or credits for the period covered by the invoice. </summary>
        public string TotalDiscounts { get; }
        /// <summary> The total GST for all account level charges.  If absent then zero is assumed. </summary>
        public string TotalGst { get; }
    }
}