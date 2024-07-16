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
    public class PagoADO
    {
        public string restService;
        static string _connect = ConexionADO.conexString;

        public PagoGeneric_Response InsertarSueldo (SueldoInsert_Req obj)
        {
            restService = _connect + "Pago/InsertarSueldo";
            PagoGeneric_Response res = new PagoGeneric_Response { CODIGO = 0 };
            try
            {
                var client = new RestClient(restService);
                var request = new RestRequest();
                request.Method = Method.Post;
                request.AddJsonBody(obj);
                var response = client.Execute<SueldoInsert_Req>(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    res = JsonConvert.DeserializeObject<PagoGeneric_Response>(response.Content);
                }
            }
            catch (Exception ex)
            {
                res.CODIGO = 0;
                res.MENSAJE = ex.Message;
            }
            return res;
        }

        public PagoGeneric_Response ActualizarSueldo(SueldoUpdate_Req obj)
        {
            restService = _connect + "Pago/ActualizarSueldo";
            PagoGeneric_Response res = new PagoGeneric_Response { CODIGO = 0 };
            try
            {
                var client = new RestClient(restService);
                var request = new RestRequest();
                request.Method = Method.Post;
                request.AddJsonBody(obj);
                var response = client.Execute<SueldoUpdate_Req>(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    res = JsonConvert.DeserializeObject<PagoGeneric_Response>(response.Content);
                }
            }
            catch (Exception ex)
            {
                res.CODIGO = 0;
                res.MENSAJE = ex.Message;
            }
            return res;
        }

        public List<ReciboBE> ListarRecibosEmpleado(int codEmpleado)
        {
            ReciboList_Req obj = new ReciboList_Req { empleado = codEmpleado};
            restService = _connect + "Pago/ListarRecibosEmpleado";

            List<ReciboBE> res = new List<ReciboBE>();
            try
            {
                var client = new RestClient(restService);
                var request = new RestRequest();
                request.Method = Method.Post;
                request.AddJsonBody(obj);
                var response = client.Execute<ReciboList_Req>(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    res = JsonConvert.DeserializeObject<List<ReciboBE>>(response.Content);
                }
            }
            catch (Exception ex)
            {

            }
            return res;
        }

        public SueldoBE ConsultarSueldoEmpleado(int codEmpleado)
        {
            SueldoConsult_Req obj = new SueldoConsult_Req { empleado = codEmpleado};
            restService = _connect + "Pago/ConsultarSueldoCod";

            SueldoBE res = new SueldoBE();
            try
            {
                var client = new RestClient(restService);
                var request = new RestRequest();
                request.Method = Method.Post;
                request.AddJsonBody(obj);
                var response = client.Execute<SueldoConsult_Req>(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    res = JsonConvert.DeserializeObject<SueldoBE>(response.Content);
                }
            }
            catch (Exception ex)
            {
                res.codEmpleado = -1;
            }
            return res;
        }
    }
}
