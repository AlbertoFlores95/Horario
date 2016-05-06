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
            this.Cita_Comentario_Dica = new HashSet<Cita_Comentario_Dica>();
            this.Cita_Comentario_Visitante = new HashSet<Cita_Comentario_Visitante>();
        }
    
        public int Folio { get; set; }
        public string Correo { get; set; }
        public string Nomina { get; set; }
        public System.DateTime Dia { get; set; }
        public System.TimeSpan HoraInicio { get; set; }
        public System.TimeSpan HoraFin { get; set; }
        public string Estatus { get; set; }
        public string Asunto { get; set; }
    
        public virtual Alumno Alumno { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cita_Comentario_Dica> Cita_Comentario_Dica { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cita_Comentario_Visitante> Cita_Comentario_Visitante { get; set; }
        public virtual Dica Dica { get; set; }
    }
}
