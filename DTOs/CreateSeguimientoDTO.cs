using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class CreateSeguimientoDTO
    {
        public int IdPersona { get; init; }
        public string EstadoVital { get; init; } = null!;
        public DateTime FechaDefuncion { get; init; }
        public string UbicacionDefuncion { get; init; } = null!;
        public string CodLugarAtencion { get; init; } = null!;
        public DateTime FechaAtencion { get; init; }
        public decimal PesoKg { get; init; }
        public short TallaCm { get; init; }
        public string CodClasificacionNutricional { get; init; } = null!;
        public string CodManejoActual { get; init; } = null!;

    }
}
