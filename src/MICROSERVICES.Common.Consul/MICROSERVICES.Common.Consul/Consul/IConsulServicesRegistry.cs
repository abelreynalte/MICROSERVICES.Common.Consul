using System.Threading.Tasks;
using Consul;

namespace MICROSERVICES.Common.Consul.Consul
{
    public interface IConsulServicesRegistry
    {
        Task<AgentService> GetAsync(string name);
    }
}