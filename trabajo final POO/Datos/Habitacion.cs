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
    
    public partial class Habitacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Habitacion()
        {
            this.Reservacion_Hab = new HashSet<Reservacion_Hab>();
        }
    
        public int Id { get; set; }
        public string Numero_Hab { get; set; }
        public string Nombre_Hab { get; set; }
        public string Precio_Hab { get; set; }
        public string Foto { get; set; }
        public int TipohabitacionId { get; set; }
    
        public virtual Tipohabitacion Tipohabitacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservacion_Hab> Reservacion_Hab { get; set; }
    }
}
