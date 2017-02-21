using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Api.V2010.Account 
{

    /// <summary>
    /// ReadAvailablePhoneNumberCountryOptions
    /// </summary>
    public class ReadAvailablePhoneNumberCountryOptions : ReadOptions<AvailablePhoneNumberCountryResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            
            return p;
        }
    }

    /// <summary>
    /// FetchAvailablePhoneNumberCountryOptions
    /// </summary>
    public class FetchAvailablePhoneNumberCountryOptions : IOptions<AvailablePhoneNumberCountryResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The country_code
        /// </summary>
        public string PathCountryCode { get; }
    
        /// <summary>
        /// Construct a new FetchAvailablePhoneNumberCountryOptions
        /// </summary>
        ///
        /// <param name="pathCountryCode"> The country_code </param>
        public FetchAvailablePhoneNumberCountryOptions(string pathCountryCode)
        {
            PathCountryCode = pathCountryCode;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}