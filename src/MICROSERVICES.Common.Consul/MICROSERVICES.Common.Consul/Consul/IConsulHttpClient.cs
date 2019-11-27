using System.Threading.Tasks;

namespace MICROSERVICES.Common.Consul.Consul
{
    public interface IConsulHttpClient
    {
        Task<T> GetAsync<T>(string requestUri);
    }
}

