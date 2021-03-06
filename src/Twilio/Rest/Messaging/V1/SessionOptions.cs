/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Messaging.V1 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// FetchSessionOptions
    /// </summary>
    public class FetchSessionOptions : IOptions<SessionResource> 
    {
        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchSessionOptions
        /// </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public FetchSessionOptions(string pathSid)
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
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// DeleteSessionOptions
    /// </summary>
    public class DeleteSessionOptions : IOptions<SessionResource> 
    {
        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteSessionOptions
        /// </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public DeleteSessionOptions(string pathSid)
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
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// CreateSessionOptions
    /// </summary>
    public class CreateSessionOptions : IOptions<SessionResource> 
    {
        /// <summary>
        /// The unique id of the SMS Service this session belongs to.
        /// </summary>
        public string MessagingServiceSid { get; }
        /// <summary>
        /// The human-readable name of this session.
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// An optional string metadata field you can use to store any data you wish.
        /// </summary>
        public string Attributes { get; set; }
        /// <summary>
        /// The date that this resource was created.
        /// </summary>
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// The date that this resource was last updated.
        /// </summary>
        public DateTime? DateUpdated { get; set; }
        /// <summary>
        /// Identity of the session's creator.
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Construct a new CreateSessionOptions
        /// </summary>
        /// <param name="messagingServiceSid"> The unique id of the SMS Service this session belongs to. </param>
        public CreateSessionOptions(string messagingServiceSid)
        {
            MessagingServiceSid = messagingServiceSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (MessagingServiceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("MessagingServiceSid", MessagingServiceSid));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }

            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", Serializers.DateTimeIso8601(DateCreated)));
            }

            if (DateUpdated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateUpdated", Serializers.DateTimeIso8601(DateUpdated)));
            }

            if (CreatedBy != null)
            {
                p.Add(new KeyValuePair<string, string>("CreatedBy", CreatedBy));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// UpdateSessionOptions
    /// </summary>
    public class UpdateSessionOptions : IOptions<SessionResource> 
    {
        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The human-readable name of this session.
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// An optional string metadata field you can use to store any data you wish.
        /// </summary>
        public string Attributes { get; set; }
        /// <summary>
        /// The date that this resource was created.
        /// </summary>
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// The date that this resource was last updated.
        /// </summary>
        public DateTime? DateUpdated { get; set; }
        /// <summary>
        /// Identity of the session's creator.
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Construct a new UpdateSessionOptions
        /// </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public UpdateSessionOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }

            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", Serializers.DateTimeIso8601(DateCreated)));
            }

            if (DateUpdated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateUpdated", Serializers.DateTimeIso8601(DateUpdated)));
            }

            if (CreatedBy != null)
            {
                p.Add(new KeyValuePair<string, string>("CreatedBy", CreatedBy));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// ReadSessionOptions
    /// </summary>
    public class ReadSessionOptions : ReadOptions<SessionResource> 
    {
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

}