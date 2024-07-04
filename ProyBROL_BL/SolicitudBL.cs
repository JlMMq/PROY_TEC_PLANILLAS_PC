using ProyBROL_ADO;
using ProyBROL_BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBROL_BL
{
    public class SolicitudBL
    {
        SolicitudADO objSolicitudADO = new SolicitudADO();

        public List<SolicitudViewBE> ListarSolicitudView (SolicitudViewRequestBE request)
        {
            return objSolicitudADO.ListarSolicitudView(request);
        }

        public SolicitudArchivoBE ConsultarArchivoSolicitud (SolicitudArchivoRequestBE request)
        {
            return objSolicitudADO.ConsultarArchivoSolicitud(request);
        }

        public GenericResponse InsertarSolicitud(SolicitudInsertBE obj)
        {
            return objSolicitudADO.InsertarSolicitud(obj);
        }

        public GenericResponse ProcesarSolicitud(SolicitudProcessBE obj)
        {
            return objSolicitudADO.ProcesarSolciitud(obj);
        }
    }
}
