using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public  class PersonaDTO
    {
        public int IdPersona { get; init; } 
        public string TipoIdentificacion { get; init; } = null!;
        public string NroIdentificacion { get; init; } = null!;
        public string PrimerNombre { get; init; } = null!;
        public string SegundoNombre { get; init; } = null!;
        public string PrimerApellido { get; init; } = null!;
        public string SegundoApellido { get; init; } = null!;
        public string Sexo { get; init; } = null!;
        public DateTime FechaNacimiento { get; init; }
        public string CodMpioResidencia { get; init; } = null!;
        public string CodAsegurador { get; init; } = null!;

    }
}
