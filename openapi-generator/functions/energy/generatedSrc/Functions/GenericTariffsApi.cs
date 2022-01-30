/*
 * CDR Energy API
 *
 * Consumer Data Right end points and payloads for the Energy sector
 *
 * The version of the OpenAPI document: 1.15.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;

namespace Agl.Cdr.Energy.Apis
{ 
    public partial class GenericTariffsApi
    { 
        [FunctionName("GenericTariffsApi_GetPlan")]
        public async Task<IActionResult> _GetPlan([HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "/energy/plans/{planId}")]HttpRequest req, ExecutionContext context, string planId)
        {
            var method = this.GetType().GetMethod("GetPlan");

            return method != null 
                ? (await ((Task<IActionResult>)method.Invoke(this, new object[] { req, context,  })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("GenericTariffsApi_ListPlans")]
        public async Task<IActionResult> _ListPlans([HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "/energy/plans")]HttpRequest req, ExecutionContext context)
        {
            var method = this.GetType().GetMethod("ListPlans");

            return method != null 
                ? (await ((Task<IActionResult>)method.Invoke(this, new object[] { req, context })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }
    }
}
