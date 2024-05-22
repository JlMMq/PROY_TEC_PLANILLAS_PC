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
    public  class CargoADO
    {
        public string restService;
        static string _connect = ConexionADO.conexString;

        public List<CargoBE> ListarCargo()
        {
            restService = _connect + "Cargo/ListarCargo";
            List<CargoBE> res = new List<CargoBE>();
            try
            {
                var client = new RestClient(restService);
                var request = new RestRequest();
                request.Method = Method.Get;
                var response = client.Execute<List<CargoBE>>(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    res = JsonConvert.DeserializeObject<List<CargoBE>>(response.Content);
                }
            }
            catch (Exception ex)
            {

            }
            return res;
        }
    }
}
