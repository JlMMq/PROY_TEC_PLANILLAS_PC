using Newtonsoft.Json;
using ProyBROL_BE;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBROL_ADO
{
    public class LoginADO
    {
        public string restService;

        static string _connect = ConexionADO.conexString;//sujeto a cambios
        
        public LoginOuBE ValidarUserSystem (LoginInBE obj)
        {
            restService = _connect + "Login/ValidarUsuario";
            LoginOuBE res = new LoginOuBE();

            try
            {
                var client = new RestClient(restService);
                var request = new RestRequest();
                request.Method = Method.Post;
                request.AddJsonBody(obj);
                var response = client.Execute<LoginOuBE>(request);
                if(response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    res = JsonConvert.DeserializeObject<LoginOuBE>(response.Content);   
                }
            }
            catch(Exception ex)
            {
                res.estadoTrans = false;
                res.codUser = -2;
            }

            /*
             RESULTADOS PARA RES.codUser
             - 0 : Significa que la operacion no es valida (contraseño o usurio incorrectos)
             - -1 : Error desde Backend
             - -2 : Error desde llamado al Backend
             */
            return res;
        }

        public bool ActualizarCorreo(UpdateMail obj)
        {
            restService = _connect + "Login/ActualizarCorreo";
            bool res = false;
            try
            {
                var client = new RestClient(restService);
                var request = new RestRequest();   
                request.Method = Method.Post;
                request.AddJsonBody(obj);
                var response = client.Execute<bool>(request);
                if(response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                   res = JsonConvert.DeserializeObject<bool>(response.Content);
                }

                return res;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool ActualizarPassword(UpdatePassword obj)
        {
            restService = _connect + "Login/ActualizarPass";
            bool res = false;
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

                return res;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
