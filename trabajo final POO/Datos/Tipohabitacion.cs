//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace trabajo_final_POO.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tipohabitacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tipohabitacion()
        {
            this.Habitacion = new HashSet<Habitacion>();
        }
    
        public int Id { get; set; }
        public string Codigo_Tipo { get; set; }
        public string Nombre_Tipo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Habitacion> Habitacion { get; set; }
    }
}
