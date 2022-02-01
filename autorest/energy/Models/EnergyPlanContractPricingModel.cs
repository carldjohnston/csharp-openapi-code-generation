// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Agl.Cdr.Energy
{
    /// <summary> The pricing model for the contract.  Contracts for gas must use SINGLE_RATE.  Note that the detail for the enumeration values are:&lt;ul&gt;&lt;li&gt;**SINGLE_RATE** - all energy usage is charged at a single unit rate no matter when it is consumed. Multiple unit rates may exist that correspond to varying volumes of usage i.e. a ‘block’ or ‘step’ tariff (first 50kWh @ X cents, next 50kWh at Y cents etc.&lt;/li&gt;&lt;li&gt;**SINGLE_RATE_CONT_LOAD** - as above, but with an additional, separate unit rate charged for all energy usage from a controlled load i.e. separately metered appliance like hot water service, pool pump etc.&lt;/li&gt;&lt;li&gt;**TIME_OF_USE** - energy usage is charged at unit rates that vary dependent on time of day and day of week that the energy is consumed&lt;/li&gt;&lt;li&gt;**TIME_OF_USE_CONT_LOAD** - as above, but with an additional, separate unit rate charged for all energy usage from a controlled load i.e. separately metered appliance like hot water service, pool pump etc.&lt;/li&gt;&lt;li&gt;**FLEXIBLE** - energy usage is charged at unit rates that vary based on external factors&lt;/li&gt;&lt;li&gt;**FLEXIBLE_CONT_LOAD** - as above, but with an additional, separate unit rate charged for all energy usage from a controlled load i.e. separately metered appliance like hot water service, pool pump etc.&lt;/li&gt;&lt;li&gt;**QUOTA** - all energy usage is charged at a single fixed rate, up to a specified usage quota/allowance. All excess usage beyond the allowance is then charged at a single unit rate (may not be the best way to explain it but it is essentially a ‘subscription’ or telco style product i.e. $50/month for up to 150kWh included usage&lt;/li&gt;&lt;/ul&gt;. </summary>
    public readonly partial struct EnergyPlanContractPricingModel : IEquatable<EnergyPlanContractPricingModel>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="EnergyPlanContractPricingModel"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnergyPlanContractPricingModel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SingleRateValue = "SINGLE_RATE";
        private const string SingleRateContLoadValue = "SINGLE_RATE_CONT_LOAD";
        private const string TimeOFUSEValue = "TIME_OF_USE";
        private const string TimeOFUSEContLoadValue = "TIME_OF_USE_CONT_LOAD";
        private const string FlexibleValue = "FLEXIBLE";
        private const string FlexibleContLoadValue = "FLEXIBLE_CONT_LOAD";
        private const string QuotaValue = "QUOTA";

        /// <summary> SINGLE_RATE. </summary>
        public static EnergyPlanContractPricingModel SingleRate { get; } = new EnergyPlanContractPricingModel(SingleRateValue);
        /// <summary> SINGLE_RATE_CONT_LOAD. </summary>
        public static EnergyPlanContractPricingModel SingleRateContLoad { get; } = new EnergyPlanContractPricingModel(SingleRateContLoadValue);
        /// <summary> TIME_OF_USE. </summary>
        public static EnergyPlanContractPricingModel TimeOFUSE { get; } = new EnergyPlanContractPricingModel(TimeOFUSEValue);
        /// <summary> TIME_OF_USE_CONT_LOAD. </summary>
        public static EnergyPlanContractPricingModel TimeOFUSEContLoad { get; } = new EnergyPlanContractPricingModel(TimeOFUSEContLoadValue);
        /// <summary> FLEXIBLE. </summary>
        public static EnergyPlanContractPricingModel Flexible { get; } = new EnergyPlanContractPricingModel(FlexibleValue);
        /// <summary> FLEXIBLE_CONT_LOAD. </summary>
        public static EnergyPlanContractPricingModel FlexibleContLoad { get; } = new EnergyPlanContractPricingModel(FlexibleContLoadValue);
        /// <summary> QUOTA. </summary>
        public static EnergyPlanContractPricingModel Quota { get; } = new EnergyPlanContractPricingModel(QuotaValue);
        /// <summary> Determines if two <see cref="EnergyPlanContractPricingModel"/> values are the same. </summary>
        public static bool operator ==(EnergyPlanContractPricingModel left, EnergyPlanContractPricingModel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnergyPlanContractPricingModel"/> values are not the same. </summary>
        public static bool operator !=(EnergyPlanContractPricingModel left, EnergyPlanContractPricingModel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EnergyPlanContractPricingModel"/>. </summary>
        public static implicit operator EnergyPlanContractPricingModel(string value) => new EnergyPlanContractPricingModel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnergyPlanContractPricingModel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnergyPlanContractPricingModel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}