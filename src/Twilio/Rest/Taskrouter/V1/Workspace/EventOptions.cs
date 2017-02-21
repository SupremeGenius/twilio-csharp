using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Taskrouter.V1.Workspace 
{

    /// <summary>
    /// FetchEventOptions
    /// </summary>
    public class FetchEventOptions : IOptions<EventResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
    
        /// <summary>
        /// Construct a new FetchEventOptions
        /// </summary>
        ///
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathSid"> The sid </param>
        public FetchEventOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
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
    /// ReadEventOptions
    /// </summary>
    public class ReadEventOptions : ReadOptions<EventResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The end_date
        /// </summary>
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// The event_type
        /// </summary>
        public string EventType { get; set; }
        /// <summary>
        /// The minutes
        /// </summary>
        public int? Minutes { get; set; }
        /// <summary>
        /// The reservation_sid
        /// </summary>
        public string ReservationSid { get; set; }
        /// <summary>
        /// The start_date
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// The task_queue_sid
        /// </summary>
        public string TaskQueueSid { get; set; }
        /// <summary>
        /// The task_sid
        /// </summary>
        public string TaskSid { get; set; }
        /// <summary>
        /// The worker_sid
        /// </summary>
        public string WorkerSid { get; set; }
        /// <summary>
        /// The workflow_sid
        /// </summary>
        public string WorkflowSid { get; set; }
    
        /// <summary>
        /// Construct a new ReadEventOptions
        /// </summary>
        ///
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        public ReadEventOptions(string pathWorkspaceSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (EndDate != null)
            {
                p.Add(new KeyValuePair<string, string>("EndDate", EndDate.Value.ToString("yyyy-MM-dd'T'HH:mm:ss")));
            }
            
            if (EventType != null)
            {
                p.Add(new KeyValuePair<string, string>("EventType", EventType));
            }
            
            if (Minutes != null)
            {
                p.Add(new KeyValuePair<string, string>("Minutes", Minutes.Value.ToString()));
            }
            
            if (ReservationSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ReservationSid", ReservationSid.ToString()));
            }
            
            if (StartDate != null)
            {
                p.Add(new KeyValuePair<string, string>("StartDate", StartDate.Value.ToString("yyyy-MM-dd'T'HH:mm:ss")));
            }
            
            if (TaskQueueSid != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskQueueSid", TaskQueueSid.ToString()));
            }
            
            if (TaskSid != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskSid", TaskSid.ToString()));
            }
            
            if (WorkerSid != null)
            {
                p.Add(new KeyValuePair<string, string>("WorkerSid", WorkerSid.ToString()));
            }
            
            if (WorkflowSid != null)
            {
                p.Add(new KeyValuePair<string, string>("WorkflowSid", WorkflowSid.ToString()));
            }
            
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            
            return p;
        }
    }

}