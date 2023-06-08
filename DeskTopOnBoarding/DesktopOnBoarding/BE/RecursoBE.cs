using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class RecursoBE
    {
        public int CodigoRecurso { get; set; }
        public string NombreRecurso { get; set; }
        public int CodigoEmpleado { get; set; }
        public bool Activo { get; set; }
        public bool Eliminado { get; set; }
        public string UsuarioInserto { get; set; }
        public System.DateTime FechaInserto { get; set; }
        public string UsuarioModifico { get; set; }
        public Nullable<System.DateTime> FechaModifico { get; set; }
        public string NombreEmpleado { get; set; }

    }
}
