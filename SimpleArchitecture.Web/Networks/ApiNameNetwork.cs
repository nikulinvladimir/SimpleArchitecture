using SimpleArchitecture.Web.Interfaces;
using SimpleArchitecture.Web.Responses;

namespace SimpleArchitecture.Web.Networks
{
    public class ApiNameNetwork : IApiNameNetwork
    {
        IHttpClientFactory _httpClientFactory;

        public ApiNameNetwork(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task<NetworkResponse> GetData(string url)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            request.Headers.Add("cookie", "usurveys=CP6XiqEGEI7IjKQG");
            request.Headers.Add("accept-language", "ru,en;q=0.9");
            request.Headers.Add("accept-encoding", "gzip, deflate, br");
            request.Headers.Add("accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7");

            var response = await _httpClientFactory.CreateClient("baseClient").SendAsync(request);

            return await NetworkResponse.CreateAsync(response);
        }
    }
}
