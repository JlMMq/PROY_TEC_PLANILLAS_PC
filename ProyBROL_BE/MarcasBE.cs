using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBROL_BE
{
    public class MarcasBE
    {   
        public int? codMarc {  get; set; }
        public int? empleado { get; set; }
        public DateTime? fecha { get; set; }
        public DateTime? hora { get; set;}
        public int? tipo { get; set; }
        public DateTime? fec_Reg { get; set; }
        public string? usu_Reg { get; set; }
        public DateTime? fec_UltMod {  get; set; }
        public string? usu_UltMod { get;set; }

    }

    public class MarcaInBE
    {
        public int? empleado { get; set; }
        public int? horario { get; set; }
        public string? usu_Reg { get; set; }
        public DateTime? fecha { get; set; }
        public int? tipo { get; set; }
    }
}
