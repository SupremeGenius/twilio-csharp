/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Autopilot.V1.Assistant;

namespace Twilio.Tests.Rest.Autopilot.V1.Assistant 
{

    [TestFixture]
    public class FieldTypeTest : TwilioTest 
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Autopilot,
                "/v1/Assistants/UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/FieldTypes/UBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                FieldTypeResource.Fetch("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"unique_name\": \"unique_name\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"assistant_sid\": \"UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"friendly_name\": \"friendly_name\",\"url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldTypes/UBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"links\": {\"field_values\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldTypes/UBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldValues\"},\"sid\": \"UBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = FieldTypeResource.Fetch("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Autopilot,
                "/v1/Assistants/UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/FieldTypes",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                FieldTypeResource.Read("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadEmptyResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"meta\": {\"url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldTypes?PageSize=50&Page=0\",\"first_page_url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldTypes?PageSize=50&Page=0\",\"previous_page_url\": null,\"page\": 0,\"page_size\": 50,\"next_page_url\": null,\"key\": \"field_types\"},\"field_types\": []}"
                                     ));

            var response = FieldTypeResource.Read("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadFullResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"meta\": {\"url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldTypes?PageSize=50&Page=0\",\"first_page_url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldTypes?PageSize=50&Page=0\",\"previous_page_url\": null,\"page\": 0,\"page_size\": 50,\"next_page_url\": null,\"key\": \"field_types\"},\"field_types\": [{\"unique_name\": \"unique_name\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"assistant_sid\": \"UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"friendly_name\": \"friendly_name\",\"url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldTypes/UBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"links\": {\"field_values\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldTypes/UBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldValues\"},\"sid\": \"UBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}]}"
                                     ));

            var response = FieldTypeResource.Read("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Autopilot,
                "/v1/Assistants/UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/FieldTypes",
                ""
            );
            request.AddPostParam("UniqueName", Serialize("unique_name"));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                FieldTypeResource.Create("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "unique_name", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"unique_name\": \"unique_name\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"assistant_sid\": \"UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"friendly_name\": \"friendly_name\",\"url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldTypes/UBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"links\": {\"field_values\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldTypes/UBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldValues\"},\"sid\": \"UBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = FieldTypeResource.Create("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "unique_name", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Autopilot,
                "/v1/Assistants/UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/FieldTypes/UBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                FieldTypeResource.Update("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestUpdateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"unique_name\": \"unique_name\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"assistant_sid\": \"UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"friendly_name\": \"friendly_name\",\"url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldTypes/UBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"links\": {\"field_values\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldTypes/UBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldValues\"},\"sid\": \"UBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = FieldTypeResource.Update("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestDeleteRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Delete,
                Twilio.Rest.Domain.Autopilot,
                "/v1/Assistants/UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/FieldTypes/UBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                FieldTypeResource.Delete("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestDeleteResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.NoContent,
                                         "null"
                                     ));

            var response = FieldTypeResource.Delete("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}