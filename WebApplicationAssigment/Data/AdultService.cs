using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using WebApplicationAssigment.Persistence;

namespace WebApplicationAssigment.Data
{
    public class AdultService : IAdultService
    {
        public async Task<IList<Adult>> GetAdultsAsync()
        {
            /*HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            using HttpClient client = new HttpClient(clientHandler);
            HttpResponseMessage responseMessage = await client.GetAsync("https://localhost:5001/Adults").ConfigureAwait(false);

            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }
            string result1 = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
            
            
            List<Adult> adults1 = JsonSerializer.Deserialize<List<Adult>>(result1, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });*/

            using FamilyDbContext context = new FamilyDbContext();
            return context.Adults.ToList();
            


        }
        
        
        public async  Task PostAdultAsync(Adult adult)
        {
            // HttpClientHandler clientHandler = new HttpClientHandler();
            // clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            //
            // HttpClient client = new HttpClient();
            //
            // string adultAsJson = JsonSerializer.Serialize(adult);
            //
            // StringContent content = new StringContent(
            //     adultAsJson,
            //     Encoding.UTF8,
            //     "application/json"
            // );
            //
            //     HttpResponseMessage response = await client.PostAsync("https://localhost:5001/Adults", content);
            //     if (!response.IsSuccessStatusCode)
            //     {
            //         throw new Exception($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            //     }

            using FamilyDbContext context = new FamilyDbContext();
            context.Adults.Add(adult);
            await context.SaveChangesAsync();

        }

        public async Task RemoveAdult(Adult adult)
        {
            /*HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            using HttpClient client = new HttpClient(clientHandler);
            HttpResponseMessage response = await client.DeleteAsync("https://localhost:5001/Adults?adultId="+adultId).ConfigureAwait(false);
            if(!response.IsSuccessStatusCode)
                throw new Exception(@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");*/

            using FamilyDbContext context = new FamilyDbContext();
            context.Adults.Remove(adult);
            await context.SaveChangesAsync();
        }
    }
}