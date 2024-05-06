using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBROL_BE
{
    public class LoginBE
    {

    }

    public class LoginInBE 
    {
        public string nomUser { get; set; }
        public string passUser { get; set; }
    }
    public class LoginOuBE
    {
        public bool estadoTrans { get; set; }
        public int codUser { get; set; }
    }
}
