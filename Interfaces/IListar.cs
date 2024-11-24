using AppTarea.Dominio.Response;

namespace AppTarea.Dominio.Interfaces
{
    public interface IListar<TEntidad, TEntidadID>
    {
        Task<Response<List<TEntidad>>>Listar();
        Task<Response<TEntidad>> SeleccionarPorID (TEntidadID entidadID);

    }
}
