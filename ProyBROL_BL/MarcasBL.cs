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
    public class MarcasBL
    {
        MarcasADO objMarcasADO = new MarcasADO();

        public bool InsertarMarca(MarcasBE objMarcaBE, int horario, DateTime fecha)
        {
            return objMarcasADO.InsertarMarca(objMarcaBE, horario, fecha);
        }
    }
}
