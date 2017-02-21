using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Api.V2010.Account 
{

    /// <summary>
    /// Fetch an instance of a conference
    /// </summary>
    public class FetchConferenceOptions : IOptions<ConferenceResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Fetch by unique conference Sid
        /// </summary>
        public string PathSid { get; }
    
        /// <summary>
        /// Construct a new FetchConferenceOptions
        /// </summary>
        ///
        /// <param name="pathSid"> Fetch by unique conference Sid </param>
        public FetchConferenceOptions(string pathSid)
        {
            PathSid = pathSid;
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

    /// <summary>
    /// Retrieve a list of conferences belonging to the account used to make the request
    /// </summary>
    public class ReadConferenceOptions : ReadOptions<ConferenceResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Filter by date created
        /// </summary>
        public DateTime? DateCreatedBefore { get; set; }
        /// <summary>
        /// Filter by date created
        /// </summary>
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// Filter by date created
        /// </summary>
        public DateTime? DateCreatedAfter { get; set; }
        /// <summary>
        /// Filter by date updated
        /// </summary>
        public DateTime? DateUpdatedBefore { get; set; }
        /// <summary>
        /// Filter by date updated
        /// </summary>
        public DateTime? DateUpdated { get; set; }
        /// <summary>
        /// Filter by date updated
        /// </summary>
        public DateTime? DateUpdatedAfter { get; set; }
        /// <summary>
        /// Filter by friendly name
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The status of the conference
        /// </summary>
        public ConferenceResource.StatusEnum Status { get; set; }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", DateCreated.ToString()));
            }
            else
            {
                if (DateCreatedBefore != null)
                {
                    p.Add(new KeyValuePair<string, string>("DateCreated<", DateCreatedBefore.ToString()));
                }
            
                if (DateCreatedAfter != null)
                {
                    p.Add(new KeyValuePair<string, string>("DateCreated>", DateCreatedAfter.ToString()));
                }
            }
            
            if (DateUpdated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateUpdated", DateUpdated.ToString()));
            }
            else
            {
                if (DateUpdatedBefore != null)
                {
                    p.Add(new KeyValuePair<string, string>("DateUpdated<", DateUpdatedBefore.ToString()));
                }
            
                if (DateUpdatedAfter != null)
                {
                    p.Add(new KeyValuePair<string, string>("DateUpdated>", DateUpdatedAfter.ToString()));
                }
            }
            
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            
            return p;
        }
    }

    /// <summary>
    /// UpdateConferenceOptions
    /// </summary>
    public class UpdateConferenceOptions : IOptions<ConferenceResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The status
        /// </summary>
        public ConferenceResource.UpdateStatusEnum Status { get; set; }
    
        /// <summary>
        /// Construct a new UpdateConferenceOptions
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        public UpdateConferenceOptions(string pathSid)
        {
            PathSid = pathSid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            
            return p;
        }
    }

}