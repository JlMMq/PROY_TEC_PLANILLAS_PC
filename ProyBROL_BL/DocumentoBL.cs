using ProyBROL_ADO;
using ProyBROL_BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBROL_BL
{
    public class DocumentoBL
    {
        DocumentoADO objDocumentoADO = new DocumentoADO();
        public DocumentoBE ConsultarDocumento(string codDoc)
        {
            return objDocumentoADO.ConsultarDocumento(codDoc);
        }
    }
}
