using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Horario.Domain.Abstract; // notar que esta línea permite usar la interface
using Horario.Domain.Entities; // notar que esta línea permite usar el código generado 


namespace Horario.Domain.Concrete
{
    public class EFProfesorRepository : IProfesorRepository
    {
        private HorarioEntities context = new HorarioEntities();
        public IEnumerable<Profesor> Profesors
        {
            get { return context.Profesors; }
        }

        public void SaveProfesor(Profesor profesor) // si le da RC-> Go to Definition (F12) puede ver la definición de la clase
        {
            Profesor dbEntry = context.Profesors.Find(profesor.Nomina);

            if (dbEntry != null) //Si encontró al profesor, actualiza los datos
            {
                dbEntry.Nomina = profesor.Nomina;
                dbEntry.Nombre = profesor.Nombre;
                dbEntry.Apellido_Paterno = profesor.Apellido_Paterno;
                dbEntry.Apellido_Materno = profesor.Apellido_Materno;
                dbEntry.Correo = profesor.Correo;
            }
            else //de lo contrario, lo añade
            {
                context.Profesors.Add(profesor);
            }
            context.SaveChanges();
        }

        public Profesor DeleteProfesor(string nomina)
        {
            Profesor dbEntry = context.Profesors.Find(nomina);
            if (dbEntry != null)
            {
                context.Profesors.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

    }
}
