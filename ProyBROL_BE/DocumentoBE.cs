using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBROL_BE
{
    public class DocumentoBE
    {
        public String? codDoc { get; set; }
        public String? descrCorta { get; set; }
        public String? descrLarga { get; set; }
        public int? longitud { get; set; }
    }

    public class DocumentoConsInBE
    {
        public string? codDoc { get; set; }
    }
}
