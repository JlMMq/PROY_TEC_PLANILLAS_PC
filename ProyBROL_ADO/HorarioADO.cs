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
    public class HorarioADO
    {
        public string restService;
        static string _connect = ConexionADO.conexString;
        public HorarioBE ConsultarHorario(int codigo)
        {
            restService = _connect + "Horario/ConsultarHorario";
            HorarioBE res = new HorarioBE();
            HorarioConsInBE obj = new HorarioConsInBE
            {
                codigo = codigo,
            };
            try
            {
                var client = new RestClient(restService);
                var request = new RestRequest();
                request.Method = Method.Post;
                request.AddJsonBody(obj);
                var response = client.Execute<HorarioBE>(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    res = JsonConvert.DeserializeObject<HorarioBE>(response.Content);
                }
            }
            catch (Exception ex)
            {

            }

            return res;
        }
    }
}
