using ProyBROL_ADO;
using ProyBROL_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
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
        public bool InsertarEmpleado(EmpleadoInsertBE obj)
        {
            return objEmpleadoADO.InsertarEmpleado(obj);
        }
        public bool ActualizarEmpleado(EmpleadoActuBE obj)
        {
            return objEmpleadoADO.ActualizarEmpleado(obj);
        }
        public bool EliminarEmpleado(int codigoEmpleado)
        {
            return objEmpleadoADO.EliminarEmpleado(codigoEmpleado);
        }
    }
}
