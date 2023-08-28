using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Entities.POCOs
{
    public class Seguimiento
    {
        public int IdSeguimiento { get; set; }
        public int IdPersona { get; set; }
        public Persona Persona { get; set; } = null!;
        public EstadoVital estadoVital { get; set; } = EstadoVital.Muesto;
        public enum EstadoVital { Vivo, Muesto }
        public DateTime FechaDefuncion { get; set; }

        public UbicacionDefuncion ubicacionDefuncion { get; set; } = UbicacionDefuncion.IPS;
        public enum UbicacionDefuncion { IPS , Hogar}
        public string CodLugarAtencion { get; set; } = null!;
        public CodSedeIPSDemo CodSedeIPSDemo { get; set; } = new CodSedeIPSDemo();

        public DateTime FechaAtencion { get; set; }
        public decimal PesoKg { get; set; }
        public short TallaCm { get; set; }
        public string CodClasificacionNutricional { get; set; } = null!;
        public DNTClasificacionNutricional DNTClasificacionNutricional { get; set; } = new DNTClasificacionNutricional();
        
        
        public string CodManejoActual { get; set; } = null!;
        public DNTManejo DNTManejos { get; set; } = new DNTManejo();
    }
}
