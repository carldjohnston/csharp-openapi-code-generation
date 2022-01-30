/*
 * CDR Energy API
 *
 * Consumer Data Right end points and payloads for the Energy sector
 *
 * The version of the OpenAPI document: 1.15.0
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

using Agl.Cdr.Energy.Client;
using Agl.Cdr.Energy.Apis;
// uncomment below to import models
//using Agl.Cdr.Energy.Models;

namespace Agl.Cdr.Energy.Test.Api
{
    /// <summary>
    ///  Class for testing GenericTariffsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GenericTariffsApiTests : IDisposable
    {
        private GenericTariffsApi instance;

        public GenericTariffsApiTests()
        {
            instance = new GenericTariffsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GenericTariffsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' GenericTariffsApi
            //Assert.IsType<GenericTariffsApi>(instance);
        }

        /// <summary>
        /// Test GetPlan
        /// </summary>
        [Fact]
        public void GetPlanTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string planId = null;
            //string xV = null;
            //string xMinV = null;
            //string xFapiInteractionId = null;
            //var response = instance.GetPlan(planId, xV, xMinV, xFapiInteractionId);
            //Assert.IsType<EnergyPlanResponse>(response);
        }

        /// <summary>
        /// Test ListPlans
        /// </summary>
        [Fact]
        public void ListPlansTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xV = null;
            //string type = null;
            //string fuelType = null;
            //string effective = null;
            //string updatedSince = null;
            //string brand = null;
            //decimal? page = null;
            //decimal? pageSize = null;
            //string xMinV = null;
            //string xFapiInteractionId = null;
            //var response = instance.ListPlans(xV, type, fuelType, effective, updatedSince, brand, page, pageSize, xMinV, xFapiInteractionId);
            //Assert.IsType<EnergyPlanListResponse>(response);
        }
    }
}
