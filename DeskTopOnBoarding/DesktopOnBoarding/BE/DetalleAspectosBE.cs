using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DetalleAspectosBE
    {
        public int CodigoDetalle { get; set; }
        public int CodigoEmpleado { get; set; }
        public int CodigoAspectoTecnico { get; set; }
        public int CodigoWill { get; set; }
        public bool Activo { get; set; }
        public bool Eliminado { get; set; }
        public string UsuarioInserto { get; set; }
        public System.DateTime FechaInserto { get; set; }
        public string UsuarioModifico { get; set; }
        public Nullable<System.DateTime> FechaModifico { get; set; }

        public string NombreEmpleado { get; set; }
        public string NombreArea { get; set; }
        public string NombrePuesto { get; set; }
        public string NombreAspectoTecnico { get; set; }
        public string NombreActividad { get; set; }
        public string NombreWill { get; set; }
        public string Descripcion { get; set; }
        public int Peso { get; set; }



    }
}
