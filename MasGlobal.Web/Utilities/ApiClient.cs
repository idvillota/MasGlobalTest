using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MasGlobal.Web.Utilities
{
    internal class ApiClient
    {
        private readonly HttpClient _httpClient;

        private Uri BaseEndpoint { get; set; }

        public ApiClient(Uri baseEndpoint)
        {
            BaseEndpoint = baseEndpoint ?? throw new ArgumentNullException("baseEndpoint");
            _httpClient = new HttpClient();
        }

        internal async Task<List<TEntity>> GetAsyncAll<TEntity>()
        {
            var response = await _httpClient.GetAsync(BaseEndpoint, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<TEntity>>(data);
            return result;
        }

    }
}
