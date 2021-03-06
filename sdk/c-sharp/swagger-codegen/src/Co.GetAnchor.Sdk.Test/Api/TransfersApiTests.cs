/* 
 * Anchor API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Api;

namespace Co.GetAnchor.Sdk.Test
{
    /// <summary>
    ///  Class for testing TransfersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TransfersApiTests
    {
        private TransfersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TransfersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TransfersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TransfersApi
            //Assert.IsInstanceOfType(typeof(TransfersApi), instance, "instance is a TransfersApi");
        }

        /// <summary>
        /// Test ApiV1TransfersGet
        /// </summary>
        [Test]
        public void ApiV1TransfersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //string customerId = null;
            //string accountId = null;
            //string destinationAccountId = null;
            //string from = null;
            //string to = null;
            //int? page = null;
            //int? size = null;
            //var response = instance.ApiV1TransfersGet(type, customerId, accountId, destinationAccountId, from, to, page, size);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test ApiV1TransfersIdGet
        /// </summary>
        [Test]
        public void ApiV1TransfersIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ApiV1TransfersIdGet(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test ApiV1TransfersPost
        /// </summary>
        [Test]
        public void ApiV1TransfersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object body = null;
            //string contentType = null;
            //var response = instance.ApiV1TransfersPost(body, contentType);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
    }

}
