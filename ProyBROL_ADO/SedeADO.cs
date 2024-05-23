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
    public class SedeADO
    {
        public string restService;
        static string _connect = ConexionADO.conexString;

        public List<SedeBE> ListarSede()
        {
            restService = _connect + "Sede/ListarSede";
            List<SedeBE> res = new List<SedeBE>();
            try
            {
                var client = new RestClient(restService);
                var request = new RestRequest();
                request.Method = Method.Get;
                var response = client.Execute<List<SedeBE>>(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    res = JsonConvert.DeserializeObject<List<SedeBE>>(response.Content);
                }
            }
            catch (Exception ex)
            {

            }
            return res;
        }
    }
}
