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
    public class DocumentoADO
    {
        public string restService;
        static string _connect = ConexionADO.conexString;

        public DocumentoBE ConsultarDocumento(string codDoc)
        {
            restService = _connect + "Documento/ConsultarDocumento";
            DocumentoBE res = new DocumentoBE();
            DocumentoConsInBE obj = new DocumentoConsInBE {
                codDoc = codDoc
            };
            try
            {
                var client = new RestClient(restService);
                var request = new RestRequest();
                request.Method = Method.Post;
                request.AddJsonBody(obj);
                var response = client.Execute<DocumentoBE>(request);
                if(response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    res = JsonConvert.DeserializeObject<DocumentoBE>(response.Content); 
                }
            }
            catch (Exception ex)
            {

            }

            return res;
        }
    }
}
