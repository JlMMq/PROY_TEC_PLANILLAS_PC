using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBROL_BE
{
    public class UserSystemBE
    {
        public int codUser { get; set; }
        public string nomUser { get; set; }
        public string? correoUser { get; set; }
        public int permisoUser { get; set; }
        public string? str_nombres { get; set; }
        public string? str_apellidos { get; set; }
        public DateTime? fec_Reg { get; set; }
        public int estdUser { get; set; }
    }

    public class UserSystemViewBE
    {
        public int codUser { get; set; }
        public string nomUser { get; set; }
        public string? correoUser { get; set; }
        public int permisoUser { get; set; }
        public string? str_nombres { get; set; }
        public string? str_apellidos { get; set; }
        public DateTime? fec_Reg { get; set; }
        public string estdUserView { get; set; }
    }
}
