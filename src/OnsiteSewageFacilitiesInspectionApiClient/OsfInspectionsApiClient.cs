using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using OnsiteSewageFacilitiesInspectionApiClient.Models;

namespace OnsiteSewageFacilitiesInspectionApiClient
{
    public class OsfInspectionsApiClient
    {
        private readonly Uri _osfInspectionsApiUrl;
        private readonly HttpClient _httpClient;
        public OsfInspectionsApiClient(Uri osfInspectionsApiUrl, string apiKey)
        {
            _osfInspectionsApiUrl = osfInspectionsApiUrl;
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("ApiKey", apiKey);
        }

        public async Task<ApiResponseContent> Send(Inspection inspection)
        {
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, _osfInspectionsApiUrl);
            var stringContent = JsonSerializer.Serialize(inspection);
            httpRequestMessage.Content = new StringContent(stringContent, Encoding.UTF8, "application/json");
            var response = await _httpClient.SendAsync(httpRequestMessage);

            if ((int) response.StatusCode == 422) // Unprocesable Entity
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<ApiResponseContent>(content, new JsonSerializerOptions {PropertyNameCaseInsensitive = true});
            }

            response.EnsureSuccessStatusCode();

            return new ApiResponseContent();
        }
    }
}
