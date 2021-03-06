/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
/// 
/// BuildResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Serverless.V1.Service 
{

    public class BuildResource : Resource 
    {
        public sealed class StatusEnum : StringEnum 
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }

            public static readonly StatusEnum Queued = new StatusEnum("queued");
            public static readonly StatusEnum Building = new StatusEnum("building");
            public static readonly StatusEnum Deploying = new StatusEnum("deploying");
            public static readonly StatusEnum Deployed = new StatusEnum("deployed");
            public static readonly StatusEnum Verified = new StatusEnum("verified");
            public static readonly StatusEnum Failed = new StatusEnum("failed");
        }

        private static Request BuildReadRequest(ReadBuildOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Serverless,
                "/v1/Services/" + options.PathServiceSid + "/Builds",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Build parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Build </returns> 
        public static ResourceSet<BuildResource> Read(ReadBuildOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<BuildResource>.FromJson("builds", response.Content);
            return new ResourceSet<BuildResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Build parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Build </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<BuildResource>> ReadAsync(ReadBuildOptions options, 
                                                                                              ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<BuildResource>.FromJson("builds", response.Content);
            return new ResourceSet<BuildResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Build </returns> 
        public static ResourceSet<BuildResource> Read(string pathServiceSid, 
                                                      int? pageSize = null, 
                                                      long? limit = null, 
                                                      ITwilioRestClient client = null)
        {
            var options = new ReadBuildOptions(pathServiceSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Build </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<BuildResource>> ReadAsync(string pathServiceSid, 
                                                                                              int? pageSize = null, 
                                                                                              long? limit = null, 
                                                                                              ITwilioRestClient client = null)
        {
            var options = new ReadBuildOptions(pathServiceSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<BuildResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<BuildResource>.FromJson("builds", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<BuildResource> NextPage(Page<BuildResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Serverless,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<BuildResource>.FromJson("builds", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<BuildResource> PreviousPage(Page<BuildResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Serverless,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<BuildResource>.FromJson("builds", response.Content);
        }

        private static Request BuildFetchRequest(FetchBuildOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Serverless,
                "/v1/Services/" + options.PathServiceSid + "/Builds/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Build parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Build </returns> 
        public static BuildResource Fetch(FetchBuildOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Build parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Build </returns> 
        public static async System.Threading.Tasks.Task<BuildResource> FetchAsync(FetchBuildOptions options, 
                                                                                  ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Build </returns> 
        public static BuildResource Fetch(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchBuildOptions(pathServiceSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Build </returns> 
        public static async System.Threading.Tasks.Task<BuildResource> FetchAsync(string pathServiceSid, 
                                                                                  string pathSid, 
                                                                                  ITwilioRestClient client = null)
        {
            var options = new FetchBuildOptions(pathServiceSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateBuildOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Serverless,
                "/v1/Services/" + options.PathServiceSid + "/Builds",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Build parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Build </returns> 
        public static BuildResource Create(CreateBuildOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Build parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Build </returns> 
        public static async System.Threading.Tasks.Task<BuildResource> CreateAsync(CreateBuildOptions options, 
                                                                                   ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="assetVersions"> The asset_versions </param>
        /// <param name="functionVersions"> The function_versions </param>
        /// <param name="dependencies"> The dependencies </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Build </returns> 
        public static BuildResource Create(string pathServiceSid, 
                                           List<string> assetVersions = null, 
                                           List<string> functionVersions = null, 
                                           string dependencies = null, 
                                           ITwilioRestClient client = null)
        {
            var options = new CreateBuildOptions(pathServiceSid){AssetVersions = assetVersions, FunctionVersions = functionVersions, Dependencies = dependencies};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="assetVersions"> The asset_versions </param>
        /// <param name="functionVersions"> The function_versions </param>
        /// <param name="dependencies"> The dependencies </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Build </returns> 
        public static async System.Threading.Tasks.Task<BuildResource> CreateAsync(string pathServiceSid, 
                                                                                   List<string> assetVersions = null, 
                                                                                   List<string> functionVersions = null, 
                                                                                   string dependencies = null, 
                                                                                   ITwilioRestClient client = null)
        {
            var options = new CreateBuildOptions(pathServiceSid){AssetVersions = assetVersions, FunctionVersions = functionVersions, Dependencies = dependencies};
            return await CreateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a BuildResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> BuildResource object represented by the provided JSON </returns> 
        public static BuildResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<BuildResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The service_sid
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// The status
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BuildResource.StatusEnum Status { get; private set; }
        /// <summary>
        /// The asset_versions
        /// </summary>
        [JsonProperty("asset_versions")]
        public List<object> AssetVersions { get; private set; }
        /// <summary>
        /// The function_versions
        /// </summary>
        [JsonProperty("function_versions")]
        public List<object> FunctionVersions { get; private set; }
        /// <summary>
        /// The dependencies
        /// </summary>
        [JsonProperty("dependencies")]
        public List<object> Dependencies { get; private set; }
        /// <summary>
        /// The date_created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date_updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private BuildResource()
        {

        }
    }

}