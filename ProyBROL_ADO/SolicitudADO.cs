using Newtonsoft.Json;
using ProyBROL_BE;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProyBROL_ADO
{
    public class SolicitudADO
    {
        public string restService;
        static string _connect = ConexionADO.conexString;

        public GenericResponse InsertarSolicitud(SolicitudInsertBE soli)
        {
            restService = _connect + "Solicitud/InsertarSolicitud";
            GenericResponse msm = new GenericResponse {
                CODIGO = 0,
                MENSAJE = "No se logro enviar o procesar la solicitud."
            }; 
            try
            {
                var client = new RestClient(restService);
                var request = new RestRequest();
                request.Method = Method.Post;
                request.AddJsonBody(soli);
                var response = client.Execute<GenericResponse>(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var res = JsonConvert.DeserializeObject<GenericResponse>(response.Content);
                    msm.CODIGO = res.CODIGO;
                    msm.MENSAJE = res.MENSAJE;
                }
            }
            catch (Exception ex)
            {
                msm.CODIGO = -1;
                msm.MENSAJE = ex.Message;
            }
            return msm;
        }

        public GenericResponse ProcesarSolciitud(SolicitudProcessBE procss)
        {
            restService = _connect + "Solicitud/ProcesarSolicitud";
            GenericResponse msm = new GenericResponse
            {
                CODIGO = 0,
                MENSAJE = "No se logro enviar o procesar la solicitud."
            };
            try
            {
                var client = new RestClient(restService);
                var request = new RestRequest();
                request.Method = Method.Post;
                request.AddJsonBody(procss);
                var response = client.Execute<GenericResponse>(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var res = JsonConvert.DeserializeObject<GenericResponse>(response.Content);
                    msm.CODIGO = res.CODIGO;
                    msm.MENSAJE = res.MENSAJE;
                }
            }
            catch (Exception ex)
            {
                msm.CODIGO = -1;
                msm.MENSAJE = ex.Message;
            }
            return msm;
        }
    }
}
