using ProyBROL_ADO;
using ProyBROL_BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBROL_BL
{
    public class HorarioBL
    {
        HorarioADO objHorarioADO = new HorarioADO();
        public HorarioBE ConsultarHorario(int? codHorario)
        {
            return objHorarioADO.ConsultarHorario(codHorario);
        }
    }
}
