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
    
    public partial class OBTAspectoTecnico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OBTAspectoTecnico()
        {
            this.OBTAspectoTecnicoActividad = new HashSet<OBTAspectoTecnicoActividad>();
            this.OBTDetalleAspectos = new HashSet<OBTDetalleAspectos>();
        }
    
        public int CodigoAspectoTecnico { get; set; }
        public string NombreAspectoTecnico { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<bool> Eliminado { get; set; }
        public string UsuarioInserto { get; set; }
        public Nullable<System.DateTime> FechaInserto { get; set; }
        public string UsuarioModifico { get; set; }
        public Nullable<System.DateTime> FechaModifico { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OBTAspectoTecnicoActividad> OBTAspectoTecnicoActividad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OBTDetalleAspectos> OBTDetalleAspectos { get; set; }
    }
}