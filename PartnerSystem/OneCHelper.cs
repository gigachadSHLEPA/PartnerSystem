using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using PartnerSystem.Models;

namespace PartnerSystem
{
    public static class OneCHelper
    {
        private static readonly HttpClient client = new HttpClient();
        private const string BaseUrl = "http://localhost:8080/1C/v8std/odata/PartnersService";

        public static async Task SavePartner(Partner partner)
        {
            var json = JsonSerializer.Serialize(partner);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{BaseUrl}/SavePartner", content);
            response.EnsureSuccessStatusCode();
        }

        public static async Task<List<Partner>> GetPartners()
        {
            var response = await client.GetAsync($"{BaseUrl}/GetPartners");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<Partner>>(json);
        }
    }
}