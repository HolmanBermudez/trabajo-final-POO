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
    
    public partial class Reservacion_Hab
    {
        public int Id { get; set; }
        public string Fecha_Entrada { get; set; }
        public string Dias_Ocupados { get; set; }
        public string Fechareal_salida { get; set; }
        public string Codigo { get; set; }
        public int HabitacionId { get; set; }
        public int ClienteId { get; set; }
    
        public virtual Habitacion Habitacion { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
