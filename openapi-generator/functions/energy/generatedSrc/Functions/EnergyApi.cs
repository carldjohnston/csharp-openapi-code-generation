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
    public partial class EnergyApi
    { 
        [FunctionName("EnergyApi_GetAccount")]
        public async Task<IActionResult> _GetAccount([HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "/energy/accounts/{accountId}")]HttpRequest req, ExecutionContext context, string accountId)
        {
            var method = this.GetType().GetMethod("GetAccount");

            return method != null 
                ? (await ((Task<IActionResult>)method.Invoke(this, new object[] { req, context,  })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("EnergyApi_GetBalanceForAccount")]
        public async Task<IActionResult> _GetBalanceForAccount([HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "/energy/accounts/{accountId}/balance")]HttpRequest req, ExecutionContext context, string accountId)
        {
            var method = this.GetType().GetMethod("GetBalanceForAccount");

            return method != null 
                ? (await ((Task<IActionResult>)method.Invoke(this, new object[] { req, context,  })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("EnergyApi_GetBillingForAccount")]
        public async Task<IActionResult> _GetBillingForAccount([HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "/energy/accounts/{accountId}/billing")]HttpRequest req, ExecutionContext context, string accountId)
        {
            var method = this.GetType().GetMethod("GetBillingForAccount");

            return method != null 
                ? (await ((Task<IActionResult>)method.Invoke(this, new object[] { req, context,  })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("EnergyApi_GetConcessions")]
        public async Task<IActionResult> _GetConcessions([HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "/energy/accounts/{accountId}/concessions")]HttpRequest req, ExecutionContext context, string accountId)
        {
            var method = this.GetType().GetMethod("GetConcessions");

            return method != null 
                ? (await ((Task<IActionResult>)method.Invoke(this, new object[] { req, context,  })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("EnergyApi_GetDERForServicePoint")]
        public async Task<IActionResult> _GetDERForServicePoint([HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "/energy/electricity/servicepoints/{servicePointId}/der")]HttpRequest req, ExecutionContext context, string servicePointId)
        {
            var method = this.GetType().GetMethod("GetDERForServicePoint");

            return method != null 
                ? (await ((Task<IActionResult>)method.Invoke(this, new object[] { req, context,  })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("EnergyApi_GetInvoicesForAccount")]
        public async Task<IActionResult> _GetInvoicesForAccount([HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "/energy/accounts/{accountId}/invoices")]HttpRequest req, ExecutionContext context, string accountId)
        {
            var method = this.GetType().GetMethod("GetInvoicesForAccount");

            return method != null 
                ? (await ((Task<IActionResult>)method.Invoke(this, new object[] { req, context,  })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("EnergyApi_GetPaymentSchedule")]
        public async Task<IActionResult> _GetPaymentSchedule([HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "/energy/accounts/{accountId}/payment-schedule")]HttpRequest req, ExecutionContext context, string accountId)
        {
            var method = this.GetType().GetMethod("GetPaymentSchedule");

            return method != null 
                ? (await ((Task<IActionResult>)method.Invoke(this, new object[] { req, context,  })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("EnergyApi_GetPlan")]
        public async Task<IActionResult> _GetPlan([HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "/energy/plans/{planId}")]HttpRequest req, ExecutionContext context, string planId)
        {
            var method = this.GetType().GetMethod("GetPlan");

            return method != null 
                ? (await ((Task<IActionResult>)method.Invoke(this, new object[] { req, context,  })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("EnergyApi_GetServicePoint")]
        public async Task<IActionResult> _GetServicePoint([HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "/energy/electricity/servicepoints/{servicePointId}")]HttpRequest req, ExecutionContext context, string servicePointId)
        {
            var method = this.GetType().GetMethod("GetServicePoint");

            return method != null 
                ? (await ((Task<IActionResult>)method.Invoke(this, new object[] { req, context,  })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("EnergyApi_GetUsageForServicePoint")]
        public async Task<IActionResult> _GetUsageForServicePoint([HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "/energy/electricity/servicepoints/{servicePointId}/usage")]HttpRequest req, ExecutionContext context, string servicePointId)
        {
            var method = this.GetType().GetMethod("GetUsageForServicePoint");

            return method != null 
                ? (await ((Task<IActionResult>)method.Invoke(this, new object[] { req, context,  })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("EnergyApi_ListAccounts")]
        public async Task<IActionResult> _ListAccounts([HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "/energy/accounts")]HttpRequest req, ExecutionContext context)
        {
            var method = this.GetType().GetMethod("ListAccounts");

            return method != null 
                ? (await ((Task<IActionResult>)method.Invoke(this, new object[] { req, context })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("EnergyApi_ListBalancesBulk")]
        public async Task<IActionResult> _ListBalancesBulk([HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "/energy/accounts/balances")]HttpRequest req, ExecutionContext context)
        {
            var method = this.GetType().GetMethod("ListBalancesBulk");

            return method != null 
                ? (await ((Task<IActionResult>)method.Invoke(this, new object[] { req, context })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("EnergyApi_ListBalancesForAccounts")]
        public async Task<IActionResult> _ListBalancesForAccounts([HttpTrigger(AuthorizationLevel.Anonymous, "POST", Route = "/energy/accounts/balances")]HttpRequest req, ExecutionContext context)
        {
            var method = this.GetType().GetMethod("ListBalancesForAccounts");

            return method != null 
                ? (await ((Task<IActionResult>)method.Invoke(this, new object[] { req, context })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("EnergyApi_ListBillingBulk")]
        public async Task<IActionResult> _ListBillingBulk([HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "/energy/accounts/billing")]HttpRequest req, ExecutionContext context)
        {
            var method = this.GetType().GetMethod("ListBillingBulk");

            return method != null 
                ? (await ((Task<IActionResult>)method.Invoke(this, new object[] { req, context })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("EnergyApi_ListBillingForAccounts")]
        public async Task<IActionResult> _ListBillingForAccounts([HttpTrigger(AuthorizationLevel.Anonymous, "POST", Route = "/energy/accounts/billing")]HttpRequest req, ExecutionContext context)
        {
            var method = this.GetType().GetMethod("ListBillingForAccounts");

            return method != null 
                ? (await ((Task<IActionResult>)method.Invoke(this, new object[] { req, context })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("EnergyApi_ListDERBulk")]
        public async Task<IActionResult> _ListDERBulk([HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "/energy/electricity/servicepoints/der")]HttpRequest req, ExecutionContext context)
        {
            var method = this.GetType().GetMethod("ListDERBulk");

            return method != null 
                ? (await ((Task<IActionResult>)method.Invoke(this, new object[] { req, context })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("EnergyApi_ListDERForServicePoints")]
        public async Task<IActionResult> _ListDERForServicePoints([HttpTrigger(AuthorizationLevel.Anonymous, "POST", Route = "/energy/electricity/servicepoints/der")]HttpRequest req, ExecutionContext context)
        {
            var method = this.GetType().GetMethod("ListDERForServicePoints");

            return method != null 
                ? (await ((Task<IActionResult>)method.Invoke(this, new object[] { req, context })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("EnergyApi_ListInvoicesBulk")]
        public async Task<IActionResult> _ListInvoicesBulk([HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "/energy/accounts/invoices")]HttpRequest req, ExecutionContext context)
        {
            var method = this.GetType().GetMethod("ListInvoicesBulk");

            return method != null 
                ? (await ((Task<IActionResult>)method.Invoke(this, new object[] { req, context })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("EnergyApi_ListInvoicesForAccounts")]
        public async Task<IActionResult> _ListInvoicesForAccounts([HttpTrigger(AuthorizationLevel.Anonymous, "POST", Route = "/energy/accounts/invoices")]HttpRequest req, ExecutionContext context)
        {
            var method = this.GetType().GetMethod("ListInvoicesForAccounts");

            return method != null 
                ? (await ((Task<IActionResult>)method.Invoke(this, new object[] { req, context })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("EnergyApi_ListPlans")]
        public async Task<IActionResult> _ListPlans([HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "/energy/plans")]HttpRequest req, ExecutionContext context)
        {
            var method = this.GetType().GetMethod("ListPlans");

            return method != null 
                ? (await ((Task<IActionResult>)method.Invoke(this, new object[] { req, context })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("EnergyApi_ListServicePoints")]
        public async Task<IActionResult> _ListServicePoints([HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "/energy/electricity/servicepoints")]HttpRequest req, ExecutionContext context)
        {
            var method = this.GetType().GetMethod("ListServicePoints");

            return method != null 
                ? (await ((Task<IActionResult>)method.Invoke(this, new object[] { req, context })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("EnergyApi_ListUsageBulk")]
        public async Task<IActionResult> _ListUsageBulk([HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "/energy/electricity/servicepoints/usage")]HttpRequest req, ExecutionContext context)
        {
            var method = this.GetType().GetMethod("ListUsageBulk");

            return method != null 
                ? (await ((Task<IActionResult>)method.Invoke(this, new object[] { req, context })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("EnergyApi_ListUsageForServicePoints")]
        public async Task<IActionResult> _ListUsageForServicePoints([HttpTrigger(AuthorizationLevel.Anonymous, "POST", Route = "/energy/electricity/servicepoints/usage")]HttpRequest req, ExecutionContext context)
        {
            var method = this.GetType().GetMethod("ListUsageForServicePoints");

            return method != null 
                ? (await ((Task<IActionResult>)method.Invoke(this, new object[] { req, context })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }
    }
}

