using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBROL_BE
{
    public class SolicitudBE
    {

    }

    public class SolicitudInsertBE
    {
        public int codSolicitante { get; set; }
        public int codSupervisor { get; set; }
        public int tipoSolic { get; set; }
        public int tipoAsunto { get; set; }
        public string asunto { get; set; }
        public string? descrip { get; set; }
        public DateTime fechaIni { get; set; }
        public DateTime fechaFin { get; set; }
        public DateTime horaSalida { get; set; }
        public DateTime horaEntrada { get; set; }

        public byte[]? archivo { get; set; }
        public string? usuario { get; set; }
    }

    public class SolicitudProcessBE
    {
        public int codSolicitud { get; set; }
        public int estado { get; set; }
        public string usuario { get; set; }
    }
    public class SolicitudViewRequestBE
    {
        public int codSupervisor { get; set; }
        public int codSolicitante { get; set; }
    }

    public class SolicitudViewBE
    {
        public int codSolicitud { get; set; }
        public int codSupervisor { get; set; }
        public int codSolicitante { get; set; }
        public string nomape { get; set; }
        public byte[]? foto { get; set; }
        public int tipoSolic { get; set; }
        public string desc_solic { get; set; }
        public int tipoAsunto { get; set; }
        public string desc_asunto { get; set; }
        public string desc_content { get; set; }
        public int estado { get; set; }
        public string desc_estado { get; set; }
    }

    public class  SolicitudArchivoRequestBE
    {
        public int codSolicitud { get; set; }
    }
    public class SolicitudArchivoBE
    {
        public byte[]? archivo { get; set; }
    }


    public class GenericResponse
    {
        public int CODIGO { get; set; }
        public string MENSAJE {  get; set; }
    }
    
}
