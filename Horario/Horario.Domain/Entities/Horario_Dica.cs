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
    
    public partial class Horario_Dica
    {
        public string Nomina { get; set; }
        public System.DateTime Dia { get; set; }
        public System.TimeSpan HoraInicio { get; set; }
        public System.TimeSpan HoraFin { get; set; }
    
        public virtual Profesor Profesor { get; set; }
    }
}
