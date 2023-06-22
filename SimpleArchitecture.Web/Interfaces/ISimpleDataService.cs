using SimpleArchitecture.Web.Models;

namespace SimpleArchitecture.Web.Interfaces
{
    public interface ISimpleDataService
    {
        Task<List<CarModel>> GetModels();
    }
}