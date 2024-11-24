using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;

namespace AppTarea.Dominio.Response
{
    public class Response<T>
    {
        public T? Data { get; set; }
        public bool IsSuccess { get; set; }
        public String? Mensaje { get; set; }
        public Exception? LogError { get; set; }

        public static Response<T> Success(T Data, string Mensaje) { 
            return new Response<T> { Data = Data, IsSuccess = true, Mensaje = Mensaje };
        }
        public static Response<T> Error(T Data, string Mensaje, Exception error) { 
            return new Response<T> { Data = Data, IsSuccess = false, Mensaje = Mensaje , LogError = error};
        }

        public static ContentResult ContentError(int code, int status, string Mensaje) {
            return new ContentResult
            {
                Content = JsonConvert.SerializeObject(new APIResponse()
                {
                    Code = code,
                    Status = status,
                    Mensaje = Mensaje
                }),
                //voy a devolver un respuesta tipo json 
                ContentType = "application/json",
                StatusCode = code
            };
        }
    }
}
