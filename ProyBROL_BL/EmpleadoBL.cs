using ProyBROL_ADO;
using ProyBROL_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBROL_BL
{
    public class EmpleadoBL
    {
        EmpleadoADO objEmpleadoADO = new EmpleadoADO();

        public EmpleadoBE ConsultarEmpleado(int codigo)
        {
            return objEmpleadoADO.ConsultarEmpleado(codigo);
        }
        public EmpleadoBE ConsultarEmpleadoCodDoc(int codigo, string doc)
        {
            return objEmpleadoADO.ConsultarEmpleadoCodDoc(codigo, doc);
        }
        public List<EmpleadoObjBE> ListarEmpleadosGrilla()
        {
            return objEmpleadoADO.ListarEmpleadosGrilla();
        }
    }
}
