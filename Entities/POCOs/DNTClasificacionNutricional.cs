using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.POCOs
{
    public  class DNTClasificacionNutricional
    {
        public string IdDNTClasificacionNutricional { get; set; }
        public int Nombre { get; set; }
        public List<Seguimiento> SeguimientoClasificacion { get; set; }
    }
}
