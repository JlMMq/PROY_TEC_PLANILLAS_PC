using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyBROL_BE
{
    public class EmpleadoBE
    {
        public int codEmpleado { get; set; }
        public String numroDoc { get; set; }
        public String tipoDoc { get; set; }
        public String apellidos { get; set; }
        public String? nombres { get; set; }
        public DateTime? fecNacimiento { get; set; }
        public String? genero { get; set; }
        public String? correo { get; set; }
        public String? direccion { get; set; }
        public int? telefono { get; set; }
        public DateTime? fecIngreso { get; set; }

        public int? codCargo { get; set; }
        public int? codArea { get; set; }
        public int? codSede { get; set; }
        public int? codHorario { get; set; }

        public byte[]? foto { get; set; }
        public int? estado { get; set; }

    }

    public class EmpleadoConsInBE
    {
        public int codigo { get; set; }
    }
}
