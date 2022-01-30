/*
 * CDR Common API
 *
 * Consumer Data Standards APIs created by the Data Standards Body (DSB), with the Data Standards Chair as the decision maker to meet the needs of the Consumer Data Right
 *
 * The version of the OpenAPI document: 1.15.0
 * Contact: contact@consumerdatastandards.gov.au
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using Agl.Cdr.Common.Attributes;
using Agl.Cdr.Common.Models;

namespace Agl.Cdr.Common.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class DiscoveryApiController : ControllerBase
    { 
        /// <summary>
        /// Get Outages
        /// </summary>
        /// <remarks>Obtain a list of scheduled outages for the implementation</remarks>
        /// <param name="xV">Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)</param>
        /// <param name="xMinV">Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable.</param>
        /// <response code="200">Success</response>
        /// <response code="0">The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;/ul&gt;</response>
        [HttpGet]
        [Route("/cds-au/v1/discovery/outages")]
        [ValidateModelState]
        [SwaggerOperation("GetOutages")]
        [SwaggerResponse(statusCode: 200, type: typeof(ResponseDiscoveryOutagesList), description: "Success")]
        [SwaggerResponse(statusCode: 0, type: typeof(ResponseErrorListV2), description: "The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;/ul&gt;")]
        public virtual IActionResult GetOutages([FromHeader][Required()]string xV, [FromHeader]string xMinV)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ResponseDiscoveryOutagesList));
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(ResponseErrorListV2));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"outages\" : [ {\n      \"duration\" : \"duration\",\n      \"outageTime\" : \"outageTime\",\n      \"isPartial\" : true,\n      \"explanation\" : \"explanation\"\n    }, {\n      \"duration\" : \"duration\",\n      \"outageTime\" : \"outageTime\",\n      \"isPartial\" : true,\n      \"explanation\" : \"explanation\"\n    } ]\n  },\n  \"meta\" : \"{}\",\n  \"links\" : {\n    \"self\" : \"self\"\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ResponseDiscoveryOutagesList>(exampleJson)
            : default(ResponseDiscoveryOutagesList);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get Status
        /// </summary>
        /// <remarks>Obtain a health check status for the implementation</remarks>
        /// <param name="xV">Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)</param>
        /// <param name="xMinV">Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable.</param>
        /// <response code="200">Success</response>
        /// <response code="0">The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;/ul&gt;</response>
        [HttpGet]
        [Route("/cds-au/v1/discovery/status")]
        [ValidateModelState]
        [SwaggerOperation("GetStatus")]
        [SwaggerResponse(statusCode: 200, type: typeof(ResponseCommonDiscoveryStatus), description: "Success")]
        [SwaggerResponse(statusCode: 0, type: typeof(ResponseErrorListV2), description: "The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;/ul&gt;")]
        public virtual IActionResult GetStatus([FromHeader][Required()]string xV, [FromHeader]string xMinV)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ResponseCommonDiscoveryStatus));
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(ResponseErrorListV2));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"updateTime\" : \"updateTime\",\n    \"explanation\" : \"explanation\",\n    \"expectedResolutionTime\" : \"expectedResolutionTime\",\n    \"detectionTime\" : \"detectionTime\",\n    \"status\" : \"OK\"\n  },\n  \"meta\" : \"{}\",\n  \"links\" : {\n    \"self\" : \"self\"\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ResponseCommonDiscoveryStatus>(exampleJson)
            : default(ResponseCommonDiscoveryStatus);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
