using System.ComponentModel.DataAnnotations;

namespace Medicamentos_Web.Models
{
    public class Usuarios
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
       
        public string Usuario { get; set; }
        public string Password { get; set; }        
        public int Estatus { get; set; }
    }
}
