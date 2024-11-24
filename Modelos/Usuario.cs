using System.ComponentModel.DataAnnotations.Schema;

namespace AppTarea
{
    public class Usuario : Auditoria
    {
        public Guid usuarioId { get; set; }
        public string nombre { get; set; }
        public string Contrasena { get; set; }
        [NotMapped]
        public List<Tarea>? Tareas { get; set; }
    }
}
