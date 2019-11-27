using System;

namespace MICROSERVICES.Common.Consul.Consul
{
    public class ConsulNotFoundException : Exception
    {
        public string ServiceName { get; set; }
        
        public ConsulNotFoundException(string serviceName) : this(string.Empty, serviceName)
        {
        }

        public ConsulNotFoundException(string message, string serviceName) : base(message)
        {
            ServiceName = serviceName;
        }
    }
}