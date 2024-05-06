﻿using Newtonsoft.Json;
using ProyBROL_BE;
using RestSharp;
using System;
using System.Collections.Generic;
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
    }
}