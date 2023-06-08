using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;


namespace DAL
{
    public class AspectoConductualDAL
    {
        public static string apiUrl { get; set; }
        /// <summary>
        /// Listar
        /// </summary>
        public async Task<List<AspectosConductualesBE>> Listar()
        {
            List<AspectosConductualesBE> lista = null;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    apiUrl = "http://localhost:34215/api/AspectoConductual/Listar/";

                    client.BaseAddress = new Uri(apiUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonPuro = await response.Content.ReadAsStringAsync();
                        var jsonDesarializado = JsonConvert.DeserializeObject(jsonPuro);
                        lista = JsonConvert
                                .DeserializeObject<List<AspectosConductualesBE>>(jsonPuro.ToString()
                                , new JsonSerializerSettings()
                                {
                                    MissingMemberHandling =
                                        MissingMemberHandling.Ignore
                                });
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
