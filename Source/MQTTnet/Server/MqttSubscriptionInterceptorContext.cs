using System.Collections.Generic;
using MQTTnet.Protocol;

namespace MQTTnet.Server
{
    public class MqttSubscriptionInterceptorContext
    {
        public MqttSubscriptionInterceptorContext(string clientId, MqttTopicFilter topicFilter, IDictionary<object, object> sessionItems)
        {
            ClientId = clientId;
            TopicFilter = topicFilter;
            SessionItems = sessionItems;
            ReasonCode = (MqttSubscribeReasonCode) topicFilter.QualityOfServiceLevel;
        }

        public string ClientId { get; }

        public MqttTopicFilter TopicFilter { get; set; }

        /// <summary>
        /// Gets or sets a key/value collection that can be used to share data within the scope of this session.
        /// </summary>
        public IDictionary<object, object> SessionItems { get; }

        public MqttSubscribeReasonCode ReasonCode { get; set; } 
        public bool AcceptSubscription { get; set; } = true;

        public bool CloseConnection { get; set; }
    }
}
