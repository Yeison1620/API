using AppTarea.Dominio.Response;

namespace AppTarea.Dominio.Interfaces
{
    public interface ICustomHeadersValidator
    {
        Response<bool> IsValid(string? apiKey, string? userRq, string? dateIn, string? dateXp, string? Issuer, string? IsAudience);
    }
}