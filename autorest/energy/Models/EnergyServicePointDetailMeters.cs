// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Agl.Cdr.Energy.Models
{
    /// <summary> The EnergyServicePointDetailMeters. </summary>
    public partial class EnergyServicePointDetailMeters
    {
        /// <summary> Initializes a new instance of EnergyServicePointDetailMeters. </summary>
        /// <param name="meterId"> The meter ID uniquely identifies a meter for a given service point.  It is unique in the context of the service point.  It is not globally unique. </param>
        /// <param name="specifications"> Technical characteristics of the meter. </param>
        /// <param name="registers"> Usage data registers available from the meter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="meterId"/>, <paramref name="specifications"/>, or <paramref name="registers"/> is null. </exception>
        internal EnergyServicePointDetailMeters(string meterId, EnergyServicePointDetailMetersSpecifications specifications, EnergyServicePointDetailMetersRegisters registers)
        {
            if (meterId == null)
            {
                throw new ArgumentNullException(nameof(meterId));
            }
            if (specifications == null)
            {
                throw new ArgumentNullException(nameof(specifications));
            }
            if (registers == null)
            {
                throw new ArgumentNullException(nameof(registers));
            }

            MeterId = meterId;
            Specifications = specifications;
            Registers = registers;
        }

        /// <summary> The meter ID uniquely identifies a meter for a given service point.  It is unique in the context of the service point.  It is not globally unique. </summary>
        public string MeterId { get; }
        /// <summary> Technical characteristics of the meter. </summary>
        public EnergyServicePointDetailMetersSpecifications Specifications { get; }
        /// <summary> Usage data registers available from the meter. </summary>
        public EnergyServicePointDetailMetersRegisters Registers { get; }
    }
}