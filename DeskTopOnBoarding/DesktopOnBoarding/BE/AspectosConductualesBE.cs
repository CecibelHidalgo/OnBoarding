using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class AspectosConductualesBE
    {
        public int CodigoWill { get; set; }
        public string NombreWill { get; set; }
        public string Descripcion { get; set; }
        public int Peso { get; set; }

        public bool Activo { get; set; }
        public bool Eliminado { get; set; }
        public string UsuarioInserto { get; set; }
        public System.DateTime FechaInserto { get; set; }
        public string UsuarioModifico { get; set; }
        public Nullable<System.DateTime> FechaModifico { get; set; }
    }
}
