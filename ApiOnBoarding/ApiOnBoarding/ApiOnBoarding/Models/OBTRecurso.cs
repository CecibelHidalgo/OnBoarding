//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiOnBoarding.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OBTRecurso
    {
        public int CodigoRecurso { get; set; }
        public string NombreRecurso { get; set; }
        public int CodigoEmpleado { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<bool> Eliminado { get; set; }
        public string UsuarioInserto { get; set; }
        public Nullable<System.DateTime> FechaInserto { get; set; }
        public string UsuarioModifico { get; set; }
        public Nullable<System.DateTime> FechaModifico { get; set; }
    
        public virtual OBTEmpleado OBTEmpleado { get; set; }
    }
}
