
using AppTarea.Dominio.Response;

namespace AppTarea.Dominio.Interfaces
{
    public interface IEditar<TEntidad>
    {
        Task<Response<bool>> Editar(TEntidad entidad);
    }
}
