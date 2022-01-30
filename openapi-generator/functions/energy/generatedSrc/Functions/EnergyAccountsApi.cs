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
    public partial class EnergyAccountsApi
    { 
        [FunctionName("EnergyAccountsApi_GetAccount")]
        public async Task<IActionResult> _GetAccount([HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "/energy/accounts/{accountId}")]HttpRequest req, ExecutionContext context, string accountId)
        {
            var method = this.GetType().GetMethod("GetAccount");

            return method != null 
                ? (await ((Task<IActionResult>)method.Invoke(this, new object[] { req, context,  })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("EnergyAccountsApi_GetConcessions")]
        public async Task<IActionResult> _GetConcessions([HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "/energy/accounts/{accountId}/concessions")]HttpRequest req, ExecutionContext context, string accountId)
        {
            var method = this.GetType().GetMethod("GetConcessions");

            return method != null 
                ? (await ((Task<IActionResult>)method.Invoke(this, new object[] { req, context,  })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("EnergyAccountsApi_GetPaymentSchedule")]
        public async Task<IActionResult> _GetPaymentSchedule([HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "/energy/accounts/{accountId}/payment-schedule")]HttpRequest req, ExecutionContext context, string accountId)
        {
            var method = this.GetType().GetMethod("GetPaymentSchedule");

            return method != null 
                ? (await ((Task<IActionResult>)method.Invoke(this, new object[] { req, context,  })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("EnergyAccountsApi_ListAccounts")]
        public async Task<IActionResult> _ListAccounts([HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "/energy/accounts")]HttpRequest req, ExecutionContext context)
        {
            var method = this.GetType().GetMethod("ListAccounts");

            return method != null 
                ? (await ((Task<IActionResult>)method.Invoke(this, new object[] { req, context })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }
    }
}
