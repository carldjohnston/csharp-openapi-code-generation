/*
 * CDR Admin API
 *
 * Data Holder Consumer Data Standards Administration End Points created by the Data Standards Body (DSB), with the Data Standards Chair as the decision maker
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
using Agl.Cdr.Admin.Attributes;
using Agl.Cdr.Admin.Models;

namespace Agl.Cdr.Admin.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class RegisterApiController : ControllerBase
    { 
        /// <summary>
        /// Metadata Update
        /// </summary>
        /// <remarks>Indicate that a critical update to the metadata for Accredited Data Recipients has been made and should be obtained</remarks>
        /// <param name="xV">Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder should respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)</param>
        /// <param name="action"></param>
        /// <param name="xMinV">Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder should respond with a 406 Not Acceptable.</param>
        /// <response code="200">Success</response>
        /// <response code="0">The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;/ul&gt;</response>
        [HttpPost]
        [Route("/cds-au/v1/admin/register/metadata")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("MetadataUpdate")]
        [SwaggerResponse(statusCode: 0, type: typeof(ResponseErrorListV2), description: "The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;/ul&gt;")]
        public virtual IActionResult MetadataUpdate([FromHeader][Required()]string xV, [FromBody]RequestMetaDataUpdate action, [FromHeader]string xMinV)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(ResponseErrorListV2));

            throw new NotImplementedException();
        }
    }
}
