using AppTarea.Dominio.Response;

namespace AppTarea.Dominio.Interfaces
{
    public interface ILogin<Login>
    {
        Task<Response<Usuario>> loguear(Login entidad);
    }
}
