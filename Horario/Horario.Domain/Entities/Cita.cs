//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Horario.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cita
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cita()
        {
            this.Citas_ComDica = new HashSet<Citas_ComDica>();
            this.Com_Visitante = new HashSet<Com_Visitante>();
        }
    
        public string Folio { get; set; }
        public string Correo { get; set; }
        public string Nomina { get; set; }
        public System.DateTime Dia { get; set; }
        public System.TimeSpan HoraInicio { get; set; }
        public System.TimeSpan HoraFin { get; set; }
        public string Estatus { get; set; }
        public string Asunto_As { get; set; }
    
        public virtual Alumno Alumno { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Citas_ComDica> Citas_ComDica { get; set; }
        public virtual Profesor Profesor { get; set; }
        public virtual Visitante_Externo Visitante_Externo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Com_Visitante> Com_Visitante { get; set; }
    }
}