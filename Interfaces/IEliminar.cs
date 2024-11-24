using AppTarea.Dominio.Response;

namespace AppTarea.Dominio.Interfaces
{
    public interface IEliminar<TEntidadID>
    {
        Task<Response<bool>> Eliminar(TEntidadID entidadId);
    }
}

