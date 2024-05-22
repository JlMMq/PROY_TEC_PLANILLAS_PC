using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBROL_BE
{
    public class DocumentoBE
    {
        public string? codDoc { get; set; }
        public string? descrCorta { get; set; }
        public string? descrLarga { get; set; }
        public int? longitud { get; set; }
    }

    public class DocumentoConsInBE
    {
        public string? codDoc { get; set; }
    }
}
