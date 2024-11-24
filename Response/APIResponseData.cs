namespace AppTarea.Dominio.Response
{
    public class APIResponseList <T> : APIResponse
    {
        public List<T>? Data { get; set; }
    }
}
