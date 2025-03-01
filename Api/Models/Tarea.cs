namespace Api.Models
{
    public class Tarea
    {

        public int Id { get; set; }

        public string Nombre_Tarea { get; set; }

        public string Descripcion_Tarea { get; set; }

        public Boolean isDeleted_Tarea { get; set; }

        public Boolean isCompleted_Tarea { get; set; }
    }
}
