using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.POCOs
{
    public  class DNTManejo
    {
        public string IdDNTManejo { get; set; } = null!;
        public string Nombre { get; set; } = null!;

        public List<Seguimiento> Seguimientos { get; set; }
    }
}
