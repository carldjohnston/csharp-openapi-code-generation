// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Agl.Cdr.Energy.Models
{
    /// <summary> The EnergyAccountDetailAllOfPlans. </summary>
    public partial class EnergyAccountDetailAllOfPlans
    {
        /// <summary> Initializes a new instance of EnergyAccountDetailAllOfPlans. </summary>
        /// <param name="servicePointIds"> An array of servicePointIds, representing NMIs, that this account is linked to. </param>
        /// <param name="planOverview"> . </param>
        /// <param name="planDetail"> Detail on the plan applicable to this account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="servicePointIds"/>, <paramref name="planOverview"/>, or <paramref name="planDetail"/> is null. </exception>
        internal EnergyAccountDetailAllOfPlans(List<string> servicePointIds, EnergyAccountAllOfPlanOverview planOverview, EnergyAccountDetailAllOfPlanDetail planDetail)
        {
            if (servicePointIds == null)
            {
                throw new ArgumentNullException(nameof(servicePointIds));
            }
            if (planOverview == null)
            {
                throw new ArgumentNullException(nameof(planOverview));
            }
            if (planDetail == null)
            {
                throw new ArgumentNullException(nameof(planDetail));
            }

            ServicePointIds = servicePointIds;
            PlanOverview = planOverview;
            PlanDetail = planDetail;
            AuthorisedContacts = new List<EnergyAccountDetailAllOfAuthorisedContacts>();
        }

        /// <summary> Initializes a new instance of EnergyAccountDetailAllOfPlans. </summary>
        /// <param name="nickname"> Optional display name for the plan provided by the customer to help differentiate multiple plans. </param>
        /// <param name="servicePointIds"> An array of servicePointIds, representing NMIs, that this account is linked to. </param>
        /// <param name="planOverview"> . </param>
        /// <param name="planDetail"> Detail on the plan applicable to this account. </param>
        /// <param name="authorisedContacts"> An array of additional contacts that are authorised to act on this account. </param>
        internal EnergyAccountDetailAllOfPlans(string nickname, IReadOnlyList<string> servicePointIds, EnergyAccountAllOfPlanOverview planOverview, EnergyAccountDetailAllOfPlanDetail planDetail, IReadOnlyList<EnergyAccountDetailAllOfAuthorisedContacts> authorisedContacts)
        {
            Nickname = nickname;
            ServicePointIds = servicePointIds;
            PlanOverview = planOverview;
            PlanDetail = planDetail;
            AuthorisedContacts = authorisedContacts;
        }

        /// <summary> Optional display name for the plan provided by the customer to help differentiate multiple plans. </summary>
        public string Nickname { get; }
        /// <summary> An array of servicePointIds, representing NMIs, that this account is linked to. </summary>
        public IReadOnlyList<string> ServicePointIds { get; }
        public EnergyAccountAllOfPlanOverview PlanOverview { get; }
        /// <summary> Detail on the plan applicable to this account. </summary>
        public EnergyAccountDetailAllOfPlanDetail PlanDetail { get; }
        /// <summary> An array of additional contacts that are authorised to act on this account. </summary>
        public IReadOnlyList<EnergyAccountDetailAllOfAuthorisedContacts> AuthorisedContacts { get; }
    }
}