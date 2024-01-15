using Newtonsoft.Json;
using SArtIntegration.qb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SArtIntegration.qb.Manager.Api
{
    public  class ApiManager
    {
        public static async Task<TResponse> PostAsync<TRequest, TResponse>(string apiUrl, TRequest requestBody)
        {
            // Serialize request body to JSON
            string jsonRequestBody = Newtonsoft.Json.JsonConvert.SerializeObject(requestBody);
            string jwtToken = UserSharedInfo.GetToken();
            using (HttpClient client = new HttpClient())
            {
                // Add JWT token to request headers
                client.DefaultRequestHeaders.Add("x-auth-token", $"Bearer {jwtToken}");

                // Create HttpContent from JSON
                HttpContent content = new StringContent(jsonRequestBody, System.Text.Encoding.UTF8, "application/json");

                // Make POST request
                HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                // Check if request is successful
                if (response.IsSuccessStatusCode)
                {
                    // Read response content as string
                    string responseContent = await response.Content.ReadAsStringAsync();
                    TResponse responseObject = JsonConvert.DeserializeObject<TResponse>(responseContent);
                    return responseObject;
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    return default; // veya isteğe bağlı olarak hata işleme stratejisi
                }
            }
        }

        public static async Task<TResponse> SendRequestAsync<TRequest, TResponse>(TRequest request, string apiUrl)
        {
            // Serialize request body to JSON
            string jsonRequestBody = JsonConvert.SerializeObject(request);
            string jwtToken = UserSharedInfo.GetToken();
            // Create HttpClient instance
            using (HttpClient client = new HttpClient())
            {
                // Add JWT token to request headers
                client.DefaultRequestHeaders.Add("x-auth-token", $"Bearer {jwtToken}");

                // Create HttpContent from JSON
                HttpContent content = new StringContent(jsonRequestBody, Encoding.UTF8, "application/json");

                // Make PUT request
                HttpResponseMessage response = await client.PutAsync(apiUrl, content);

                // Check if request is successful
                if (response.IsSuccessStatusCode)
                {
                    // Read response content as string
                    string responseContent = await response.Content.ReadAsStringAsync();

                    // Deserialize response JSON to the specified type
                    TResponse responseObject = JsonConvert.DeserializeObject<TResponse>(responseContent);

                    return responseObject;
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    return default(TResponse);
                }
            }
        }
    }
}
