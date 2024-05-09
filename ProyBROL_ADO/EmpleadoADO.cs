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
    public class EmpleadoADO
    {
        public string restService;
        static string _connect = ConexionADO.conexString;
        public EmpleadoBE ConsultarEmpleado(int codigo)
        {
            restService = _connect + "Empleado/ConsultarEmpleado";
            EmpleadoBE res = new EmpleadoBE();
            EmpleadoConsInBE obj = new EmpleadoConsInBE
            {
                codigo = codigo
            };
            try
            {
                var client = new RestClient(restService);
                var request = new RestRequest();
                request.Method = Method.Post;
                request.AddJsonBody(obj);
                var response = client.Execute<EmpleadoBE>(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    res = JsonConvert.DeserializeObject<EmpleadoBE>(response.Content);
                }
            }
            catch (Exception ex)
            {

            }

            return res;
        }

        public EmpleadoBE ConsultarEmpleadoCodDoc(int codigo, string numroDoc)
        {
            restService = _connect + "Empleado/ConsultarEmpleado";
            EmpleadoBE res = new EmpleadoBE();
            EmpleadoConsCodDocInBE obj = new EmpleadoConsCodDocInBE
            {
                codigo = codigo,
                numroDoc = numroDoc
            };
            try
            {
                var client = new RestClient(restService);
                var request = new RestRequest();
                request.Method = Method.Post;
                request.AddJsonBody(obj);
                var response = client.Execute<EmpleadoBE>(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    res = JsonConvert.DeserializeObject<EmpleadoBE>(response.Content);
                }
            }
            catch (Exception ex)
            {

            }

            return res;
        }
    }
}
