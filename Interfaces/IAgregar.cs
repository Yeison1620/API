using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTarea.Dominio.Response;

namespace AppTarea.Dominio.Interfaces
{
    public interface IAgregar<TEntidad>
    {
        Task<Response<TEntidad>> Agregar(TEntidad entidad); 
    }
}
