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
    public class AreaADO
    {
        public string restService;
        static string _connect = ConexionADO.conexString;

        public List<AreaBE> ListarArea()
        {
            restService = _connect + "Area/ListarArea";
            List<AreaBE> res = new List<AreaBE>();
            try
            {
                var client = new RestClient(restService);
                var request = new RestRequest();
                request.Method = Method.Get;
                var response = client.Execute<List<AreaBE>>(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    res = JsonConvert.DeserializeObject<List<AreaBE>>(response.Content);
                }
            }
            catch (Exception ex)
            {

            }
            return res;
        }   
    }
}
