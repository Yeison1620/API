using System.ComponentModel.DataAnnotations.Schema;

namespace AppTarea
{
    public class TareaUsuario
    {
        public Guid tareaId { get; set; }
        [NotMapped]
        public Tarea Tarea { get; set; }
        public Guid usuarioId { get; set; }
        [NotMapped]
        public Usuario Usuario { get; set; }
    }
}
