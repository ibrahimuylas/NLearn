using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NLearn.UI.Services
{
    public abstract class ServiceBase<T> where T : ServiceBase<T>, new()
    {
        //private string _ServiceUri = System.Configuration.ConfigurationManager.AppSettings["ServiceUri"];

        private static T _instance = new T();
        public static T Instance
        {
            get
            {
                return _instance;
            }
        }

        public async Task<X> GetDataFromAPI<X>(string apiName)
        {
            X result = default(X);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5000/");

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync($"api/{apiName}");

                if (Res.IsSuccessStatusCode)
                {
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    result = JsonConvert.DeserializeObject<X>(EmpResponse);

                }
            }
            return result;

        }
    }
}
