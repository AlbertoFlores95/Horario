using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Horario.Domain.Abstract; // notar que esta línea permite usar la interface
using Horario.Domain.Entities; // notar que esta línea permite usar el código generado 

namespace Horario.Domain.Concrete
{
    public class EFDicaRepository : IDicaRepository
    {
        private HorarioEntities context = new HorarioEntities();
        public IEnumerable<Dica> Dicas
        {
            get { return context.Dicas; }
        }

        public void SaveDica(Dica Dica) // si le da RC-> Go to Definition (F12) puede ver la definición de la clase
        {
            Dica dbEntry = context.Dicas.Find(Dica.Nomina);

            if (dbEntry != null) //Si encontró al profesor, actualiza los datos
            {
                dbEntry.Nomina = Dica.Nomina;
                dbEntry.Nombre = Dica.Nombre;
                dbEntry.Apellido_Paterno = Dica.Apellido_Paterno;
                dbEntry.Apellido_Materno = Dica.Apellido_Materno;
                dbEntry.Correo = Dica.Correo;
            }
            else //de lo contrario, lo añade
            {
                context.Dicas.Add(Dica);
            }
            context.SaveChanges();
        }

        public Dica DeleteDica(string Nomina)
        {
            Dica dbEntry = context.Dicas.Find(Nomina);
            if (dbEntry != null)
            {
                context.Dicas.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

    }
}

