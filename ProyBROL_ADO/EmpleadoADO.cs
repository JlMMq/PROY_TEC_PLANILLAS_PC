using Newtonsoft.Json;
using ProyBROL_BE;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public List<EmpleadoObjBE> ListarEmpleadosGrilla()
        {
            restService = _connect + "Empleado/ListarEmpleadosView";
            List<EmpleadoObjBE> res = new List<EmpleadoObjBE>();
            try
            {
                var client = new RestClient(restService);
                var request = new RestRequest();
                request.Method = Method.Get;
                var response = client.Execute<List<EmpleadoObjBE>>(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    res = JsonConvert.DeserializeObject<List<EmpleadoObjBE>>(response.Content);
                }
            }
            catch (Exception ex)
            {

            }
            return res; 
        }

        public bool InsertarEmpleado(EmpleadoInsertBE obj)
        {
            restService = _connect + "Empleado/InsertarEmpleado";
            bool res = false;
            try
            {
                var client = new RestClient(restService);
                var request = new RestRequest();
                request.Method = Method.Post;
                request.AddJsonBody(obj);
                var response = client.Execute<EmpleadoInsertBE>(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    res = JsonConvert.DeserializeObject<bool>(response.Content);
                }
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }

        public bool ActualizarEmpleado(EmpleadoActuBE obj)
        {
            restService = _connect + "Empleado/ActualizarEmpleado";
            bool res = false;
            try
            {
                var client = new RestClient(restService);
                var request = new RestRequest();
                request.Method = Method.Post;
                request.AddJsonBody(obj);
                var response = client.Execute<EmpleadoActuBE>(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    res = JsonConvert.DeserializeObject<bool>(response.Content);
                }
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }

        public bool EliminarEmpleado(int _codEmpleado)
        {
            EmpleadoElimBE obj = new EmpleadoElimBE
            {
                codEmpleado = _codEmpleado
            };
            restService = _connect + "Empleado/EliminarEmpleado";
            bool res = false;
            try
            {
                var client = new RestClient(restService);
                var request = new RestRequest();
                request.Method = Method.Post;
                request.AddJsonBody(obj);
                var response = client.Execute<EmpleadoElimBE>(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    res = JsonConvert.DeserializeObject<bool>(response.Content);
                }
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }
    }
}
