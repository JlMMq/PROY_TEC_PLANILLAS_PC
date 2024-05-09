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
            bool result = false;
            MarcaOuBE res;
            restService = _connect + "Marca/InsertarMarca";
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
                var response = client.Execute<MarcaOuBE>(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    res = JsonConvert.DeserializeObject<MarcaOuBE>(response.Content);
                    if (res.valor)
                    {
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }
    }
}
