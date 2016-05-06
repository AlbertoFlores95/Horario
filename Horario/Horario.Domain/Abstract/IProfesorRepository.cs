using System.Collections.Generic;
using Horario.Domain.Entities;

namespace Horario.Domain.Abstract
{
    public interface IProfesorRepository
    {
        IEnumerable<Profesor> Profesors { get; }
        void SaveProfesor(Profesor profesor);
        Profesor DeleteProfesor(string ID);
    }
}
