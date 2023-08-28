using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCasePorts
{
    public interface IGetAllSeguimientoInputPort
    {
        Task<Task> Handle();
    }
}
