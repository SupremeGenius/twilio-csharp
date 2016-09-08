using Newtonsoft.Json;
using System;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Creators.Api.V2010.Account;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Api.V2010.Account {

    public class ValidationRequest : Resource {
        /**
         * create
         * 
         * @param accountSid The account_sid
         * @param phoneNumber The phone_number
         * @return ValidationRequestCreator capable of executing the create
         */
        public static ValidationRequestCreator Create(string accountSid, Twilio.Types.PhoneNumber phoneNumber) {
            return new ValidationRequestCreator(accountSid, phoneNumber);
        }
    
        /**
         * Create a ValidationRequestCreator to execute create.
         * 
         * @param phoneNumber The phone_number
         * @return ValidationRequestCreator capable of executing the create
         */
        public static ValidationRequestCreator Create(Twilio.Types.PhoneNumber phoneNumber) {
            return new ValidationRequestCreator(phoneNumber);
        }
    
        /**
         * Converts a JSON string into a ValidationRequest object
         * 
         * @param json Raw JSON string
         * @return ValidationRequest object represented by the provided JSON
         */
        public static ValidationRequest FromJson(string json) {
            // Convert all checked exceptions to Runtime
            try {
                return JsonConvert.DeserializeObject<ValidationRequest>(json);
            } catch (JsonException e) {
                throw new ApiException(e.Message, e);
            }
        }
    
        [JsonProperty("account_sid")]
        private readonly string accountSid;
        [JsonProperty("phone_number")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        private readonly Twilio.Types.PhoneNumber phoneNumber;
        [JsonProperty("friendly_name")]
        private readonly string friendlyName;
        [JsonProperty("validation_code")]
        private readonly int? validationCode;
        [JsonProperty("call_sid")]
        private readonly string callSid;
    
        public ValidationRequest() {
        
        }
    
        private ValidationRequest([JsonProperty("account_sid")]
                                  string accountSid, 
                                  [JsonProperty("phone_number")]
                                  Twilio.Types.PhoneNumber phoneNumber, 
                                  [JsonProperty("friendly_name")]
                                  string friendlyName, 
                                  [JsonProperty("validation_code")]
                                  int? validationCode, 
                                  [JsonProperty("call_sid")]
                                  string callSid) {
            this.accountSid = accountSid;
            this.phoneNumber = phoneNumber;
            this.friendlyName = friendlyName;
            this.validationCode = validationCode;
            this.callSid = callSid;
        }
    
        /**
         * @return The account_sid
         */
        public string GetAccountSid() {
            return this.accountSid;
        }
    
        /**
         * @return The phone_number
         */
        public Twilio.Types.PhoneNumber GetPhoneNumber() {
            return this.phoneNumber;
        }
    
        /**
         * @return The friendly_name
         */
        public string GetFriendlyName() {
            return this.friendlyName;
        }
    
        /**
         * @return The validation_code
         */
        public int? GetValidationCode() {
            return this.validationCode;
        }
    
        /**
         * @return The call_sid
         */
        public string GetCallSid() {
            return this.callSid;
        }
    }
}