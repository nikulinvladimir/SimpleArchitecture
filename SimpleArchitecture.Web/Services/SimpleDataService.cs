using Newtonsoft.Json;
using SimpleArchitecture.Web.Interfaces;
using SimpleArchitecture.Web.Models;

namespace SimpleArchitecture.Web.Services
{
    public class SimpleDataService : ISimpleDataService
    {
        IApiNameNetwork _apiNameNetwork;

        public SimpleDataService(IApiNameNetwork apiNameNetwork)
        {
            _apiNameNetwork = apiNameNetwork;
        }


        public async Task<List<Model>> GetModels()
        {
            var response = await _apiNameNetwork.GetData("http://somesite.ru");

            var listModels = JsonConvert.DeserializeObject<List<Model>>(response.Data);

            return listModels;
        }
    }
}
