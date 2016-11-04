using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Taskrouter.V1.Workspace 
{

    public class EventResource : Resource 
    {
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="sid"> The sid </param>
        /// <returns> EventFetcher capable of executing the fetch </returns> 
        public static EventFetcher Fetcher(string workspaceSid, string sid)
        {
            return new EventFetcher(workspaceSid, sid);
        }
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <returns> EventReader capable of executing the read </returns> 
        public static EventReader Reader(string workspaceSid)
        {
            return new EventReader(workspaceSid);
        }
    
        /// <summary>
        /// Converts a JSON string into a EventResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> EventResource object represented by the provided JSON </returns> 
        public static EventResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<EventResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        [JsonProperty("account_sid")]
        public string accountSid { get; set; }
        [JsonProperty("actor_sid")]
        public string actorSid { get; set; }
        [JsonProperty("actor_type")]
        public string actorType { get; set; }
        [JsonProperty("actor_url")]
        public Uri actorUrl { get; set; }
        [JsonProperty("description")]
        public string description { get; set; }
        [JsonProperty("event_data")]
        public Dictionary<string, string> eventData { get; set; }
        [JsonProperty("event_date")]
        public DateTime? eventDate { get; set; }
        [JsonProperty("event_type")]
        public string eventType { get; set; }
        [JsonProperty("resource_sid")]
        public string resourceSid { get; set; }
        [JsonProperty("resource_type")]
        public string resourceType { get; set; }
        [JsonProperty("resource_url")]
        public Uri resourceUrl { get; set; }
        [JsonProperty("sid")]
        public string sid { get; set; }
        [JsonProperty("source")]
        public string source { get; set; }
        [JsonProperty("source_ip_address")]
        public string sourceIpAddress { get; set; }
        [JsonProperty("url")]
        public Uri url { get; set; }
    
        public EventResource()
        {
        
        }
    
        private EventResource([JsonProperty("account_sid")]
                              string accountSid, 
                              [JsonProperty("actor_sid")]
                              string actorSid, 
                              [JsonProperty("actor_type")]
                              string actorType, 
                              [JsonProperty("actor_url")]
                              Uri actorUrl, 
                              [JsonProperty("description")]
                              string description, 
                              [JsonProperty("event_data")]
                              Dictionary<string, string> eventData, 
                              [JsonProperty("event_date")]
                              string eventDate, 
                              [JsonProperty("event_type")]
                              string eventType, 
                              [JsonProperty("resource_sid")]
                              string resourceSid, 
                              [JsonProperty("resource_type")]
                              string resourceType, 
                              [JsonProperty("resource_url")]
                              Uri resourceUrl, 
                              [JsonProperty("sid")]
                              string sid, 
                              [JsonProperty("source")]
                              string source, 
                              [JsonProperty("source_ip_address")]
                              string sourceIpAddress, 
                              [JsonProperty("url")]
                              Uri url)
                              {
            this.accountSid = accountSid;
            this.actorSid = actorSid;
            this.actorType = actorType;
            this.actorUrl = actorUrl;
            this.description = description;
            this.eventData = eventData;
            this.eventDate = MarshalConverter.DateTimeFromString(eventDate);
            this.eventType = eventType;
            this.resourceSid = resourceSid;
            this.resourceType = resourceType;
            this.resourceUrl = resourceUrl;
            this.sid = sid;
            this.source = source;
            this.sourceIpAddress = sourceIpAddress;
            this.url = url;
        }
    }
}