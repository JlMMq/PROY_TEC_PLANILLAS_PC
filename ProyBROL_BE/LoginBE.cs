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
        public string nomUser { get; set; }

        public string str_nombres { get; set; }
        public string str_apellidos { get; set; }
        public string correoUser { get; set; }

        public int permiso { get; set; }
    }

    public class UpdateMail
    {
        public int codUser { get; set; }
        public string correo { get; set; }
    }

    public class UpdatePassword
    {
        public int codUser { get; set; }
        public string passUser { get; set; }
    }
}
