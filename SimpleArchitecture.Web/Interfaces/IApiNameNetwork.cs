using SimpleArchitecture.Web.Responses;

namespace SimpleArchitecture.Web.Interfaces
{
    public interface IApiNameNetwork
    {
        Task<NetworkResponse> GetData(string url);
    }
}