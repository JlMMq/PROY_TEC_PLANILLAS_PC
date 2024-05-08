using Newtonsoft.Json;
using ProyBROL_BE;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBROL_ADO
{
    public class DiarioADO
    {
        public string restService;
        static string _connect = ConexionADO.conexString;

        public DiarioBE ConsultarDiario (int codigo)
        {
            restService = _connect + "Diario/ConsultarDiario";
            DiarioBE res = new DiarioBE();
            DiarioConsInBE obj = new DiarioConsInBE
            {
                codigo = codigo,
            };
            try
            {
                var client = new RestClient(restService);
                var request = new RestRequest();
                request.Method = Method.Post;
                request.AddJsonBody(obj);
                var response = client.Execute<DiarioBE>(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    res = JsonConvert.DeserializeObject<DiarioBE>(response.Content);
                }
            }
            catch (Exception ex)
            {

            }

            return res;
        }
    }
}
