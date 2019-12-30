using BethanysPieShopMobile.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopMobile.Core.Repository
{
    public class PieRepositoryWeb
    {
        public async Task<List<Pie>> GetAllPies()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var responseMessage = await httpClient.GetAsync("http://192.168.10.147:5000/api/pies");
            if (!responseMessage.IsSuccessStatusCode) return null;
            var jsonResult = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
            var pies = JsonConvert.DeserializeObject<IEnumerable<Pie>>(jsonResult);
            return pies.ToList();
        }

        public async Task<Pie> GetPieById(int id)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var responseMessage = await httpClient.GetAsync($"http://192.168.10.147:5000/api/pies/{id}");
            if (!responseMessage.IsSuccessStatusCode) return null;
            var jsonResult = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
            var pie = JsonConvert.DeserializeObject<Pie>(jsonResult);
            return pie;
        }
    }
}
