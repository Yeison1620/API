namespace AppTarea.Dominio.Response
{
    public class APIResponseData <T> : APIResponse
    {
        public T? Data { get; set; }
    }
}
