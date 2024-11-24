using AppTarea.Dominio.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTarea.Dominio.Interfaces
{
    public interface IAsignarTarea<TEntidad>
    {
        Task<Response<bool>> Asignar(TareaUsuario tUsuario);
    }
}
