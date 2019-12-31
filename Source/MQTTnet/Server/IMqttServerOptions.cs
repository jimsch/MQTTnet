using System;
using MQTTnet.Server.ExtendedAuthenticationExchange;

namespace MQTTnet.Server
{
    public interface IMqttServerOptions
    {
        string ClientId { get; set; }

        bool EnablePersistentSessions { get; }

        int MaxPendingMessagesPerClient { get; }
        MqttPendingMessagesOverflowStrategy PendingMessagesOverflowStrategy { get; }

        TimeSpan DefaultCommunicationTimeout { get; }

        IMqttServerConnectionValidator ConnectionValidator { get; }
        IMqttServerSubscriptionInterceptor SubscriptionInterceptor { get; }
        IMqttServerUnsubscriptionInterceptor UnsubscriptionInterceptor { get; }
        IMqttServerApplicationMessageInterceptor ApplicationMessageInterceptor { get; }
        IMqttServerClientMessageQueueInterceptor ClientMessageQueueInterceptor { get; }
        IMqttEnhancedAuthenticationBrokerHandler EnhancedAuthenticationBrokerHandler { get; set; }

        MqttServerTcpEndpointOptions DefaultEndpointOptions { get; }
        MqttServerTlsTcpEndpointOptions TlsEndpointOptions { get; }

        IMqttServerStorage Storage { get; }       
        

    }
}