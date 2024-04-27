
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text;

namespace ERPProject.App
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;

        public ApiClient()
        {
            _httpClient = new HttpClient();
        }

        public async Task<T> GetAsync<T>(string url) where T : class
        {
            return await SendRequestAsync<T>(HttpMethod.Get, url);
        }

        public async Task<T> PostAsync<T>(string url, object data) where T : class
        {
            return await SendRequestAsync<T>(HttpMethod.Post, url, data);
        }

        public async Task<T> PutAsync<T>(string url, object data) where T : class
        {
            return await SendRequestAsync<T>(HttpMethod.Put, url, data);
        }

        public async Task<T> DeleteAsync<T>(string url) where T : class
        {
            return await SendRequestAsync<T>(HttpMethod.Delete, url);
        }

        private async Task<T> SendRequestAsync<T>(HttpMethod method, string url, object data = null) where T :class
        {
            var request = new HttpRequestMessage(method, url);

            if (data != null)
            {
                var json = JsonSerializer.Serialize(data);
                request.Content = new StringContent(json, Encoding.UTF8, "application/json");
            }

            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(jsonResponse);
        }
    }
    public class HttpResponse
    {

    }
}
