using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Horario.Domain.Entities;


namespace Horario.Domain.Abstract
{
    public interface ICarreraRepository
    {
        IEnumerable<Carrera> Carreras { get; }
        void SaveCarrera(Carrera carrera);
        Carrera DeleteCarrera(string ID);
    }

}
