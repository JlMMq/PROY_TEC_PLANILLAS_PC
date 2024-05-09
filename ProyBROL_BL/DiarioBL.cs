using ProyBROL_ADO;
using ProyBROL_BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBROL_BL
{
    public class DiarioBL
    {
        DiarioADO objDiarioADO = new DiarioADO();
        public DiarioBE ConsultarDiario(int codigo)
        {
            return objDiarioADO.ConsultarDiario(codigo);
        }

        public DiarioBE ConsultarDiarioFecEmpl(DateTime fec, int empleado)
        {
            return objDiarioADO.ConsultarDiarioFecEmpl(fec, empleado);
        }
    }
}
