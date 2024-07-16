using ProyBROL_ADO;
using ProyBROL_BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBROL_BL
{
    public class PagoBL
    {
        PagoADO pagoADO = new PagoADO();

        public PagoGeneric_Response InsertarSueldo(SueldoInsert_Req obj)
        {
            return pagoADO.InsertarSueldo(obj);
        }

        public PagoGeneric_Response ActualizarSueldo(SueldoUpdate_Req obj)
        {
            return pagoADO.ActualizarSueldo(obj);
        }

        public List<ReciboBE> ListarRecibosEmpleado(int codEmpleado)
        {
            return pagoADO.ListarRecibosEmpleado(codEmpleado);
        }

        public SueldoBE ConsultarSueldoEmpleado(int codEmpleado)
        {
            return pagoADO.ConsultarSueldoEmpleado(codEmpleado);
        }
    }
}
