namespace SimpleArchitecture.Web.Responses
{
    public class NetworkResponse
    {
        public string Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; }

        private NetworkResponse()
        {


        }

        public static async Task<NetworkResponse> CreateAsync(HttpResponseMessage responseMessage)
        {
            if (responseMessage.IsSuccessStatusCode)
            {

                var answer = await responseMessage.Content.ReadAsStringAsync();

                return new NetworkResponse
                {
                    Data = answer
                };
            }

            return new NetworkResponse
            {
                Success = false,
                Message = responseMessage.StatusCode.ToString()
            };

        }
    }
}
