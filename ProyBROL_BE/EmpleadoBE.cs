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
        public DateTime fecNacimiento { get; set; }
        public String? genero { get; set; }
        public String? correo { get; set; }
        public String? direccion { get; set; }
        public int? telefono { get; set; }
        public DateTime fecIngreso { get; set; }

        public int? codCargo { get; set; }
        public int? codArea { get; set; }
        public int? codSede { get; set; }
        public int codHorario { get; set; }

        public byte[]? foto { get; set; }
        public int? estado { get; set; }

    }
    public class EmpleadoObjBE
    {
        public int codEmpleado { get; set; }
        public string numroDoc { get; set; }
        public string apellidos { get; set; }
        public string nombres { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }
        public int estado { get; set; }
        public string nombreDocumento { get; set; }
        public string nombreCargo { get; set; }
        public string nombreArea { get; set; }
        public string nombreHorario { get; set; }
    }

    public class EmpleadoConsInBE
    {
        public int codigo { get; set; }
    }

    public class EmpleadoConsCodDocInBE
    {
        public int codigo { get; set; }
        public string numroDoc { get; set; }
    }

    public class EmpleadoInsertBE
    {
        public string numroDoc { get; set; }
        public string tipoDoc { get; set; }
        public string apellidos { get; set; }
        public string nombres { get; set; }
        public DateTime? fecNacimiento { get; set; }
        public string genero { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }
        public int? telefono { get; set; }
        public DateTime? fecIngreso { get; set; }

        public int codCargo { get; set; }
        public int codArea { get; set; }
        public int codSede { get; set; }
        public int codHorario { get; set; }
        public byte[]? foto { get; set; }
        public string? usu_Reg { get; set; }
        public int? estado { get; set; }
    }

    public class EmpleadoActuBE
    {
        public int codEmpleado { get; set; }
        public string numroDoc { get; set; }
        public string tipoDoc { get; set; }
        public string apellidos { get; set; }
        public string nombres { get; set; }
        public DateTime fecNacimiento { get; set; }
        public string genero { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }
        public DateTime fecIngreso { get; set; }

        public int codCargo { get; set; }
        public int codArea { get; set; }
        public int codSede { get; set; }
        public int codHorario { get; set; }

        public byte[] foto { get; set; }
        public string usu_UltMod { get; set; }
        public int estado { get; set; }
    }

    public class EmpleadoElimBE
    {
        public int codEmpleado { get; set; }
    }
}
