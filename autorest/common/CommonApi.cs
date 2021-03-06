// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace Agl.Cdr.Common
{
    public class CommonApi
    {
        private ILogger<CommonApi> _logger;

        /// <summary> Initializes a new instance of CommonApi. </summary>
        /// <param name="logger"> Class logger. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="logger"/> is null. </exception>
        public CommonApi(ILogger<CommonApi> logger)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            _logger = logger;
        }

        /// <summary>
        /// Obtain basic information on the customer that has authorised the current session
        /// 
        /// ### Conventions
        /// In the customer payloads relevant conventions are explained here, in one place.
        /// 
        /// #### Given Names
        /// 
        /// `firstName` represents the first of a person&apos;s given names.
        /// 
        /// `middleNames` represents a collection of given names if the person has more than one given name.
        /// 
        /// Where a data holder holds a person&apos;s given names as a single string in source systems, it may not possible in some situations to reliably split these given names into their component first and middle names. In these situations, data holders MAY use the `firstName` field to return the single string of given names and an empty `middleNames` array.
        /// 
        /// For example, a person whose given names are &quot;John Paul Winston&quot; but the data holder cannot determine what is the first name, can return `&quot;firstName&quot;: &quot;John Paul Winston&quot;`.
        /// </summary>
        /// <param name="req"> Raw HTTP Request. </param>
        /// <param name="cancellationToken"> The cancellation token provided on Function shutdown. </param>
        [FunctionName("GetCustomerAsync_get")]
        public async Task<IActionResult> GetCustomerAsync([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "common/customer")] HttpRequest req, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("HTTP trigger function processed a request.");

            // TODO: Handle Documented Responses.
            // Spec Defines: HTTP 200

            throw new NotImplementedException();
        }

        /// <summary>
        /// Obtain detailed information on the authorised customer within the current session.
        /// 
        /// Obsolete versions: [v1](includes/obsolete/get-customer-detail-v1.html).
        /// </summary>
        /// <param name="req"> Raw HTTP Request. </param>
        /// <param name="cancellationToken"> The cancellation token provided on Function shutdown. </param>
        [FunctionName("GetCustomerDetailAsync_get")]
        public async Task<IActionResult> GetCustomerDetailAsync([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "common/customer/detail")] HttpRequest req, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("HTTP trigger function processed a request.");

            // TODO: Handle Documented Responses.
            // Spec Defines: HTTP 200

            throw new NotImplementedException();
        }
    }
}
