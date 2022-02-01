// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Agl.Cdr.Energy.Models
{
    /// <summary> Required if methodUType is percentOfBill. </summary>
    public partial class EnergyPlanDiscountsItemPercentOfBill
    {
        /// <summary> Initializes a new instance of EnergyPlanDiscountsItemPercentOfBill. </summary>
        /// <param name="rate"> The rate of the discount applied to the bill amount. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="rate"/> is null. </exception>
        internal EnergyPlanDiscountsItemPercentOfBill(string rate)
        {
            if (rate == null)
            {
                throw new ArgumentNullException(nameof(rate));
            }

            Rate = rate;
        }

        /// <summary> The rate of the discount applied to the bill amount. </summary>
        public string Rate { get; }
    }
}
