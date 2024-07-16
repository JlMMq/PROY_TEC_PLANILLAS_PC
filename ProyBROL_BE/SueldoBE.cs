using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBROL_BE
{
    public class SueldoBE
    {
        public int codSueldo { get; set; }
        public int codEmpleado { get; set; }
        public double sueldo {  get; set; }
        public int essalud { get; set; }
        public int afil_onp { get; set; }
        public int afil_afp { get; set; }
    }
    public class SueldoInsert_Req
    {
        public int empleado { get; set; }
        public double sueldo { get; set; }
        public int flag_essalud { get; set; }
        public int flag_onp { get; set; }
        public int flag_afp { get; set; }
        public string usuario { get; set; }
    }

    public class SueldoUpdate_Req
    {
        public int empleado { get; set; }
        public double sueldo { get; set; }
        public int flag_essalud { get; set; }
        public int flag_onp { get; set; }
        public int flag_afp { get; set; }
        public string usuario { get; set; }
    }

    public class PagoGeneric_Response
    {
        public int CODIGO { get; set; }
        public string MENSAJE { get; set; }
    }

    public class ReciboBE
    {
        public int codRecibo { get; set; }
        public int codEmpleado { get; set; }
        public string apenom { get; set; }
        public DateTime fechaEmision { get; set; }
        public string moneda { get; set; }
        public double sueldoBase { get; set; }
        public double descEssalud { get; set; }
        public double descOnp { get; set; }
        public double descAfp { get; set; }
        public double descFaltas { get; set; }
        public double sueldoTotal { get; set; }
    }

    public class ReciboList_Req
    {
        public int empleado { get; set; }
    }

    public class SueldoConsult_Req: ReciboList_Req 
    {
        
    }
}
