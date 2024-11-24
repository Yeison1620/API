using System.ComponentModel.DataAnnotations.Schema;

namespace AppTarea
{
    public class Tarea : Auditoria
    {
        public Guid tareaId { get; set; }
        public DateTime fechaAdicion { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
        public string prioridad { get; set; }
        public DateTime fechaInicio { get; set; }   
        public DateTime fechaFin { get; set; }
        public string comentarios { get; set; }
        [NotMapped]
        public List<Usuario>? Usuarios { get; set; }
    }
}
