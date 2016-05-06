using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Horario.Domain.Abstract;
using Horario.Domain.Entities;


namespace Horario.Domain.Concrete
{
    public class EFCarreraRepository : ICarreraRepository //error común de novato, olivar hacer la clase public!!!!!!!!!
    {
        private HorarioEntities context = new HorarioEntities();
        public IEnumerable<Carrera> Carreras
        {
            get { return context.Carreras; }
        }

        public void SaveCarrera(Carrera carrera) // si le da RC-> Go to Definition (F12) puede ver la definición de la clase
        {
            Carrera dbEntry = context.Carreras.Find(carrera.Carrera_Siglas);

            if (dbEntry != null) //Si encontró la carrera, actualiza los datos
            {
                dbEntry.Carrera_Siglas = carrera.Carrera_Siglas;
                dbEntry.Carrera_Nombre = carrera.Carrera_Nombre;

            }
            else //de lo contrario, lo añade
            {
                context.Carreras.Add(carrera);
            }
            context.SaveChanges();
        }


        public Carrera DeleteCarrera(string siglas)
        {
            Carrera dbEntry = context.Carreras.Find(siglas);
            if (dbEntry != null)
            {
                context.Carreras.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
