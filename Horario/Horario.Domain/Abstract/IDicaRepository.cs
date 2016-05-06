using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Horario.Domain.Entities;

namespace Horario.Domain.Abstract
{

    public interface IDicaRepository
    {
        IEnumerable<Dica> Dicas { get; }
        void SaveDica(Dica Dica);
        Dica DeleteDica(String ID);
    }

}

