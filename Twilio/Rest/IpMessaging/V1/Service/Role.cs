using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Creators.IpMessaging.V1.Service;
using Twilio.Deleters.IpMessaging.V1.Service;
using Twilio.Exceptions;
using Twilio.Fetchers.IpMessaging.V1.Service;
using Twilio.Http;
using Twilio.Readers.IpMessaging.V1.Service;
using Twilio.Updaters.IpMessaging.V1.Service;

namespace Twilio.Rest.IpMessaging.V1.Service {

    public class Role : SidResource {
        public sealed class RoleType : IStringEnum {
            public const string CHANNEL="channel";
            public const string DEPLOYMENT="deployment";
        
            private string value;
            
            public RoleType() { }
            
            public RoleType(string value) {
                this.value = value;
            }
            
            public override string ToString() {
                return value;
            }
            
            public static implicit operator RoleType(string value) {
                return new RoleType(value);
            }
            
            public static implicit operator string(RoleType value) {
                return value.ToString();
            }
            
            public void FromString(string value) {
                this.value = value;
            }
        }
    
        /**
         * fetch
         * 
         * @param serviceSid The service_sid
         * @param sid The sid
         * @return RoleFetcher capable of executing the fetch
         */
        public static RoleFetcher Fetch(string serviceSid, string sid) {
            return new RoleFetcher(serviceSid, sid);
        }
    
        /**
         * delete
         * 
         * @param serviceSid The service_sid
         * @param sid The sid
         * @return RoleDeleter capable of executing the delete
         */
        public static RoleDeleter Delete(string serviceSid, string sid) {
            return new RoleDeleter(serviceSid, sid);
        }
    
        /**
         * create
         * 
         * @param serviceSid The service_sid
         * @param friendlyName The friendly_name
         * @param type The type
         * @param permission The permission
         * @return RoleCreator capable of executing the create
         */
        public static RoleCreator Create(string serviceSid, string friendlyName, Role.RoleType type, List<string> permission) {
            return new RoleCreator(serviceSid, friendlyName, type, permission);
        }
    
        /**
         * read
         * 
         * @param serviceSid The service_sid
         * @return RoleReader capable of executing the read
         */
        public static RoleReader Read(string serviceSid) {
            return new RoleReader(serviceSid);
        }
    
        /**
         * update
         * 
         * @param serviceSid The service_sid
         * @param sid The sid
         * @param permission The permission
         * @return RoleUpdater capable of executing the update
         */
        public static RoleUpdater Update(string serviceSid, string sid, List<string> permission) {
            return new RoleUpdater(serviceSid, sid, permission);
        }
    
        /**
         * Converts a JSON string into a Role object
         * 
         * @param json Raw JSON string
         * @return Role object represented by the provided JSON
         */
        public static Role FromJson(string json) {
            // Convert all checked exceptions to Runtime
            try {
                return JsonConvert.DeserializeObject<Role>(json);
            } catch (JsonException e) {
                throw new ApiException(e.Message, e);
            }
        }
    
        [JsonProperty("sid")]
        private readonly string sid;
        [JsonProperty("account_sid")]
        private readonly string accountSid;
        [JsonProperty("service_sid")]
        private readonly string serviceSid;
        [JsonProperty("friendly_name")]
        private readonly string friendlyName;
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        private readonly Role.RoleType type;
        [JsonProperty("permissions")]
        private readonly List<string> permissions;
        [JsonProperty("date_created")]
        private readonly DateTime? dateCreated;
        [JsonProperty("date_updated")]
        private readonly DateTime? dateUpdated;
        [JsonProperty("url")]
        private readonly Uri url;
    
        public Role() {
        
        }
    
        private Role([JsonProperty("sid")]
                     string sid, 
                     [JsonProperty("account_sid")]
                     string accountSid, 
                     [JsonProperty("service_sid")]
                     string serviceSid, 
                     [JsonProperty("friendly_name")]
                     string friendlyName, 
                     [JsonProperty("type")]
                     Role.RoleType type, 
                     [JsonProperty("permissions")]
                     List<string> permissions, 
                     [JsonProperty("date_created")]
                     string dateCreated, 
                     [JsonProperty("date_updated")]
                     string dateUpdated, 
                     [JsonProperty("url")]
                     Uri url) {
            this.sid = sid;
            this.accountSid = accountSid;
            this.serviceSid = serviceSid;
            this.friendlyName = friendlyName;
            this.type = type;
            this.permissions = permissions;
            this.dateCreated = MarshalConverter.DateTimeFromString(dateCreated);
            this.dateUpdated = MarshalConverter.DateTimeFromString(dateUpdated);
            this.url = url;
        }
    
        /**
         * @return The sid
         */
        public override string GetSid() {
            return this.sid;
        }
    
        /**
         * @return The account_sid
         */
        public string GetAccountSid() {
            return this.accountSid;
        }
    
        /**
         * @return The service_sid
         */
        public string GetServiceSid() {
            return this.serviceSid;
        }
    
        /**
         * @return The friendly_name
         */
        public string GetFriendlyName() {
            return this.friendlyName;
        }
    
        /**
         * @return The type
         */
        public Role.RoleType GetRoleType() {
            return this.type;
        }
    
        /**
         * @return The permissions
         */
        public List<string> GetPermissions() {
            return this.permissions;
        }
    
        /**
         * @return The date_created
         */
        public DateTime? GetDateCreated() {
            return this.dateCreated;
        }
    
        /**
         * @return The date_updated
         */
        public DateTime? GetDateUpdated() {
            return this.dateUpdated;
        }
    
        /**
         * @return The url
         */
        public Uri GetUrl() {
            return this.url;
        }
    }
}