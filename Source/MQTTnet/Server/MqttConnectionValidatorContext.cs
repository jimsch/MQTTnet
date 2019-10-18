using System.Security.Cryptography.X509Certificates;
using System.Text;
using MQTTnet.Adapter;
using MQTTnet.Packets;
using MQTTnet.Protocol;

namespace MQTTnet.Server
{
    public class MqttConnectionValidatorContext
    {
        public MqttConnectionValidatorContext(
            string clientId, 
            string username, 
            byte[] password, 
            MqttApplicationMessage willMessage, 
            string endpoint, 
            bool isSecureConnection,
            X509Certificate2 clientCertificate)
        {
            ClientId = clientId;
            Username = username;
            RawPassword = password;
            WillMessage = willMessage;
            Endpoint = endpoint;
            IsSecureConnection = isSecureConnection;
            ClientCertificate = clientCertificate;
        }

// #if FOR_JIM
        public IMqttChannelAdapter ClientChannel { get; set; }
        public MqttConnectPacket ConnectPacket { get; set; }
// #endif

        public string ClientId { get; }

        public string Username { get; }

        public string Password => Encoding.UTF8.GetString(RawPassword ?? new byte[0]);

        public byte[] RawPassword { get; }

        public MqttApplicationMessage WillMessage { get; }

        public string Endpoint { get; }

        public bool IsSecureConnection { get; }

        public X509Certificate2 ClientCertificate { get; }

        public MqttConnectReturnCode ReturnCode { get; set; } = MqttConnectReturnCode.ConnectionAccepted;
    }
}
