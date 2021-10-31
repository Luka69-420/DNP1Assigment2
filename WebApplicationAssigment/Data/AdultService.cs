using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace WebApplicationAssigment.Data
{
    public class AdultService : IAdultService
    {
        public async Task<IList<Adult>> GetAdultsAsync()
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            using HttpClient client = new HttpClient(clientHandler);
            HttpResponseMessage responseMessage = await client.GetAsync("https://localhost:5001/Adults").ConfigureAwait(false);

            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            string result = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

            List<Adult> adults = JsonSerializer.Deserialize<List<Adult>>(result, new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            return adults;
        }
        
        public async  Task PostAdultAsync()
        {
            HttpClient client = new HttpClient();

            Adult adult = new()
            {
                Id = 69,
                Age = 32,
                EyeColor = "blue",
                FirstName = "first",
                LastName = "last",
                HairColor = "hair",
                JobTitle = null,
                Height = 100,
                Sex = "m",
                Weight = 100
            };

            string adultAsJson = JsonSerializer.Serialize(adult);

            StringContent content = new StringContent(
                adultAsJson,
                Encoding.UTF8,
                "application/json"
            );

                HttpResponseMessage response = await client.PostAsync("https://localhost:5001/Adults", content);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Error: {response.StatusCode}, {response.ReasonPhrase}");
                }
            
        }

        public void RemoveAdult(int adultId)
        {
            throw new System.NotImplementedException();
        }
    }
}