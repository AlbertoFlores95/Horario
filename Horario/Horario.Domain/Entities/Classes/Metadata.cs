using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Horario.Domain.Entities
{
    public class CarreraMetadata
    {
        [StringLength(4)]
        public string Siglas { set; get; }
    }
}
