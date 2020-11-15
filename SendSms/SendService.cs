using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SendSms
{
    public class SendService
    {
        const string URI = "https://www.kurtename.com/api/v1/submitsm";
        const string X_API_KEY = "Place API key here!";
        public async Task<SendResponse> Submit(SendRequest sendRequest)
        {
            var jsonInString = JsonConvert.SerializeObject(sendRequest);
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Add("x-api-key", X_API_KEY);
                    var httpResponse = await httpClient.PostAsync(URI, new StringContent(jsonInString, Encoding.UTF8, "application/json"));
                    var contentString = await httpResponse.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<SendResponse>(contentString);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, ex.StackTrace, "Failed to send SMS");
                return null;
            }
        }
    }
}