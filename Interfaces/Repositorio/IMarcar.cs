using AppTarea.Dominio.Response;

namespace AppTarea.Dominio.Interfaces.Repositorio
{
    public interface IMarcar<TEntidad>
    {
        Task<Response<bool>> Marcar(Tarea tarea);
    }
}