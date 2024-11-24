namespace AppTarea.Dominio.Response
{
    public class APIResponseLogin : APIResponse
    {
        public string? Token { get; set; }
        public DateTime Expiration { get; set; }
        public Usuario? User { get; set; }
    }
}
