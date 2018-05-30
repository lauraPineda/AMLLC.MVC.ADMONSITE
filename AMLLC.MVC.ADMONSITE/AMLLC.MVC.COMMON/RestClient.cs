using AMLLC.CORE.ENTITIES;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AMLLC.MVC.COMMON
{
    /// <summary>
    /// Clase generica que invoca un api rest.
    /// </summary>
    /// <typeparam name="TResponse">Genérico para RESPONSE.</typeparam>
    /// <typeparam name="TRequest">Genérico para REQUEST.</typeparam>
    public class RestClient<TResponse,TRequest>
    {
        public Task<ResponseDTO<TResponse>> Call(RequestDTO<TRequest> request, string route)
        {
            return Task.Run(() =>
            {
                var response = new ResponseDTO<TResponse>();
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Key.GetBaseApiAdress());
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    StringContent content = new StringContent(JsonConvert.SerializeObject(request), System.Text.Encoding.UTF8, "application/json");
                    // HTTP POST
                    HttpResponseMessage httpResponseMessage = client.PostAsync(route, content).Result;
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        string data = httpResponseMessage.Content.ReadAsStringAsync().Result;
                        response = JsonConvert.DeserializeObject<ResponseDTO<TResponse>>(data);
                    }
                }
                return response;
            });
            
        }
    }
}
