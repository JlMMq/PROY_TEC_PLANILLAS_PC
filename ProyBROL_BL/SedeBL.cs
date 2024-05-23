using ProyBROL_ADO;
using ProyBROL_BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBROL_BL
{
    public class SedeBL
    {
        SedeADO objSedeADO = new SedeADO();
        public List<SedeBE> ListarSede()
        {
            return objSedeADO.ListarSede();
        }

    }
}
