/*
 * CDR Admin API
 *
 * Data Holder Consumer Data Standards Administration End Points created by the Data Standards Body (DSB), with the Data Standards Chair as the decision maker
 *
 * The version of the OpenAPI document: 1.15.0
 * Contact: contact@consumerdatastandards.gov.au
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Agl.Cdr.Admin.Client;
using Agl.Cdr.Admin.Apis;
// uncomment below to import models
//using Agl.Cdr.Admin.Models;

namespace Agl.Cdr.Admin.Test.Api
{
    /// <summary>
    ///  Class for testing RegisterApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RegisterApiTests : IDisposable
    {
        private RegisterApi instance;

        public RegisterApiTests()
        {
            instance = new RegisterApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RegisterApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' RegisterApi
            //Assert.IsType<RegisterApi>(instance);
        }

        /// <summary>
        /// Test MetadataUpdate
        /// </summary>
        [Fact]
        public void MetadataUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xV = null;
            //RequestMetaDataUpdate action = null;
            //string xMinV = null;
            //instance.MetadataUpdate(xV, action, xMinV);
        }
    }
}
