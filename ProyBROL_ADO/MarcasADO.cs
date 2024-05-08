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
    public class MarcasADO
    {
        private string restService;
        static string _connect = ConexionADO.conexString;

        public bool InsertarMarca(MarcasBE objMarcaBE, int horario, DateTime fecha)
        {
            bool res = false;
            restService = _connect + "Marcas/InsertarMarca";
            MarcaInBE obj = new MarcaInBE
            {
                empleado = objMarcaBE.empleado,
                horario = horario,
                usu_Reg = objMarcaBE.usu_Reg,
                fecha = fecha,
                tipo = objMarcaBE.tipo
            };
            try
            {
                var client = new RestClient(restService);
                var request = new RestRequest();
                request.Method = Method.Post;
                request.AddJsonBody(obj);
                var response = client.Execute<bool>(request);
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
