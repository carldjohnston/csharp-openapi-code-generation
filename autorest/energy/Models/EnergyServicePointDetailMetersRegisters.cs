// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Agl.Cdr.Energy;

namespace Agl.Cdr.Energy.Models
{
    /// <summary> Usage data registers available from the meter. </summary>
    public partial class EnergyServicePointDetailMetersRegisters
    {
        /// <summary> Initializes a new instance of EnergyServicePointDetailMetersRegisters. </summary>
        /// <param name="registerId"> Unique identifier of the register within this service point.  Is not globally unique. </param>
        /// <param name="registerSuffix"> Register suffix of the meter register where the meter reads are obtained. </param>
        /// <param name="registerConsumptionType"> Indicates the consumption type of register. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="registerId"/> or <paramref name="registerSuffix"/> is null. </exception>
        internal EnergyServicePointDetailMetersRegisters(string registerId, string registerSuffix, EnergyServicePointDetailMetersRegistersRegisterConsumptionType registerConsumptionType)
        {
            if (registerId == null)
            {
                throw new ArgumentNullException(nameof(registerId));
            }
            if (registerSuffix == null)
            {
                throw new ArgumentNullException(nameof(registerSuffix));
            }

            RegisterId = registerId;
            RegisterSuffix = registerSuffix;
            RegisterConsumptionType = registerConsumptionType;
        }

        /// <summary> Initializes a new instance of EnergyServicePointDetailMetersRegisters. </summary>
        /// <param name="registerId"> Unique identifier of the register within this service point.  Is not globally unique. </param>
        /// <param name="registerSuffix"> Register suffix of the meter register where the meter reads are obtained. </param>
        /// <param name="averagedDailyLoad"> The energy delivered through a connection point or metering point over an extended period normalised to a &apos;per day&apos; basis (kWh). This value is calculated annually. </param>
        /// <param name="registerConsumptionType"> Indicates the consumption type of register. </param>
        /// <param name="networkTariffCode"> The Network Tariff Code is a free text field containing a code supplied and published by the local network service provider. </param>
        /// <param name="unitOfMeasure"> The unit of measure for data held in this register. </param>
        /// <param name="timeOfDay"> Code to identify the time validity of register contents. </param>
        /// <param name="multiplier"> Multiplier required to take a register value and turn it into a value representing billable energy. </param>
        /// <param name="controlledLoad"> Indicates whether the energy recorded by this register is created under a Controlled Load regime. ControlledLoad field will have &apos;No&apos; if register does not relate to a Controlled Load.  If the register relates to a Controlled Load, it should contain a description of the Controlled Load regime. ControlledLoad field will have &apos;No&apos; if register does not relate to a Controlled Load, “Yes” if register relates to a Controlled Load If absent the status is unknown. </param>
        /// <param name="consumptionType"> Actual/Subtractive Indicator. Note the details of enumeration values below: &lt;ul&gt;&lt;li&gt;**ACTUAL** implies volume of energy actually metered between two dates&lt;/li&gt;&lt;li&gt;**CUMULATIVE** indicates a meter reading for a specific date. A second Meter Reading is required to determine the consumption between those two Meter Reading dates&lt;/li&gt;&lt;/ul&gt;. </param>
        internal EnergyServicePointDetailMetersRegisters(string registerId, string registerSuffix, float? averagedDailyLoad, EnergyServicePointDetailMetersRegistersRegisterConsumptionType registerConsumptionType, string networkTariffCode, string unitOfMeasure, EnergyServicePointDetailMetersRegistersTimeOfDay? timeOfDay, float? multiplier, bool? controlledLoad, EnergyServicePointDetailMetersRegistersConsumptionType? consumptionType)
        {
            RegisterId = registerId;
            RegisterSuffix = registerSuffix;
            AveragedDailyLoad = averagedDailyLoad;
            RegisterConsumptionType = registerConsumptionType;
            NetworkTariffCode = networkTariffCode;
            UnitOfMeasure = unitOfMeasure;
            TimeOfDay = timeOfDay;
            Multiplier = multiplier;
            ControlledLoad = controlledLoad;
            ConsumptionType = consumptionType;
        }

        /// <summary> Unique identifier of the register within this service point.  Is not globally unique. </summary>
        public string RegisterId { get; }
        /// <summary> Register suffix of the meter register where the meter reads are obtained. </summary>
        public string RegisterSuffix { get; }
        /// <summary> The energy delivered through a connection point or metering point over an extended period normalised to a &apos;per day&apos; basis (kWh). This value is calculated annually. </summary>
        public float? AveragedDailyLoad { get; }
        /// <summary> Indicates the consumption type of register. </summary>
        public EnergyServicePointDetailMetersRegistersRegisterConsumptionType RegisterConsumptionType { get; }
        /// <summary> The Network Tariff Code is a free text field containing a code supplied and published by the local network service provider. </summary>
        public string NetworkTariffCode { get; }
        /// <summary> The unit of measure for data held in this register. </summary>
        public string UnitOfMeasure { get; }
        /// <summary> Code to identify the time validity of register contents. </summary>
        public EnergyServicePointDetailMetersRegistersTimeOfDay? TimeOfDay { get; }
        /// <summary> Multiplier required to take a register value and turn it into a value representing billable energy. </summary>
        public float? Multiplier { get; }
        /// <summary> Indicates whether the energy recorded by this register is created under a Controlled Load regime. ControlledLoad field will have &apos;No&apos; if register does not relate to a Controlled Load.  If the register relates to a Controlled Load, it should contain a description of the Controlled Load regime. ControlledLoad field will have &apos;No&apos; if register does not relate to a Controlled Load, “Yes” if register relates to a Controlled Load If absent the status is unknown. </summary>
        public bool? ControlledLoad { get; }
        /// <summary> Actual/Subtractive Indicator. Note the details of enumeration values below: &lt;ul&gt;&lt;li&gt;**ACTUAL** implies volume of energy actually metered between two dates&lt;/li&gt;&lt;li&gt;**CUMULATIVE** indicates a meter reading for a specific date. A second Meter Reading is required to determine the consumption between those two Meter Reading dates&lt;/li&gt;&lt;/ul&gt;. </summary>
        public EnergyServicePointDetailMetersRegistersConsumptionType? ConsumptionType { get; }
    }
}
