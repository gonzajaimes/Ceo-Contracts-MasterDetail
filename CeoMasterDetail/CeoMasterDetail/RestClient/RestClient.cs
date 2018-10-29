using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CeoMasterDetail.RestClient
{
    /// <summary>
    /// RestClient implements methods for calling CRUD operations
    /// using HTTP.
    /// </summary>

    public class RestClient<T>
    {
        private const string WebServiceUrl = "http://192.168.0.43:5000/api/Proyectos/";

        public async Task<List<T>> GetAsync()
        {
            var httpClient = new HttpClient();

            var json = await httpClient.GetStringAsync(WebServiceUrl);

            var proyectos = JsonConvert.DeserializeObject<List<T>>(json);

            return proyectos;
        }
        public async Task<List<T>> GetMenuItemsAsync()
        {
            var httpClient = new HttpClient();

            var json = await httpClient.GetStringAsync(WebServiceUrl + "clientes");

            var menuItems = JsonConvert.DeserializeObject<List<T>>(json);

            return menuItems;
        }

        public async Task<bool> PostAsync(T t)
        {
            var httpClient = new HttpClient();

            var json = JsonConvert.SerializeObject(t);

            HttpContent httpContent = new StringContent(json);

            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var result = await httpClient.PostAsync(WebServiceUrl, httpContent);

            return result.IsSuccessStatusCode;
        }

        public async Task<bool> PutAsync(int id, T t)
        {
            var httpClient = new HttpClient();

            var json = JsonConvert.SerializeObject(t);

            HttpContent httpContent = new StringContent(json);

            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var result = await httpClient.PutAsync(WebServiceUrl + id, httpContent);

            return result.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var httpClient = new HttpClient();

            var response = await httpClient.DeleteAsync(WebServiceUrl + id);

            return response.IsSuccessStatusCode;
        }

        public async Task<List<T>> GetByKeywordAsync(decimal keyword)
        {
            var httpClient = new HttpClient();

            var json = await httpClient.GetStringAsync(WebServiceUrl + "searchId/" + keyword);

            var employees = JsonConvert.DeserializeObject<List<T>>(json);

            return employees;
        }

    }
}
