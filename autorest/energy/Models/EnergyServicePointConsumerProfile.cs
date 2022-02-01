// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Agl.Cdr.Energy;

namespace Agl.Cdr.Energy.Models
{
    /// <summary> The EnergyServicePointConsumerProfile. </summary>
    public partial class EnergyServicePointConsumerProfile
    {
        /// <summary> Initializes a new instance of EnergyServicePointConsumerProfile. </summary>
        internal EnergyServicePointConsumerProfile()
        {
        }

        /// <summary> Initializes a new instance of EnergyServicePointConsumerProfile. </summary>
        /// <param name="classification"> A code that defines the consumer class as defined in the National Energy Retail Regulations, or in overriding Jurisdictional instruments. </param>
        /// <param name="threshold"> A code that defines the consumption threshold as defined in the National Energy Retail Regulations, or in overriding Jurisdictional instruments. Note the details of enumeration values below: &lt;ul&gt;&lt;li&gt;**LOW** - Consumption is less than the ‘lower consumption threshold’ as defined in the National Energy Retail Regulations&lt;/li&gt;&lt;li&gt;**MEDIUM** - Consumption is equal to or greater than the ‘lower consumption threshold’, but less than the ‘upper consumption threshold’, as defined in the National Energy Retail Regulations&lt;/li&gt;&lt;li&gt;**HIGH** - Consumption is equal to or greater than the ‘upper consumption threshold’ as defined in the National Energy Retail Regulations&lt;/li&gt;&lt;/ul&gt;. </param>
        internal EnergyServicePointConsumerProfile(EnergyServicePointConsumerProfileClassification? classification, EnergyServicePointConsumerProfileThreshold? threshold)
        {
            Classification = classification;
            Threshold = threshold;
        }

        /// <summary> A code that defines the consumer class as defined in the National Energy Retail Regulations, or in overriding Jurisdictional instruments. </summary>
        public EnergyServicePointConsumerProfileClassification? Classification { get; }
        /// <summary> A code that defines the consumption threshold as defined in the National Energy Retail Regulations, or in overriding Jurisdictional instruments. Note the details of enumeration values below: &lt;ul&gt;&lt;li&gt;**LOW** - Consumption is less than the ‘lower consumption threshold’ as defined in the National Energy Retail Regulations&lt;/li&gt;&lt;li&gt;**MEDIUM** - Consumption is equal to or greater than the ‘lower consumption threshold’, but less than the ‘upper consumption threshold’, as defined in the National Energy Retail Regulations&lt;/li&gt;&lt;li&gt;**HIGH** - Consumption is equal to or greater than the ‘upper consumption threshold’ as defined in the National Energy Retail Regulations&lt;/li&gt;&lt;/ul&gt;. </summary>
        public EnergyServicePointConsumerProfileThreshold? Threshold { get; }
    }
}
