using BE.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE.Dto
{
    public class CorredorUpdateDto
    {
        
        public string? Email { get; set; }

        public string? Password { get; set; }

        public string? Nombre { get; set; }

        public string? Apellido { get; set; }

    
        public IFormFile? Imagen { get; set; }

        public DateTime? FechaNacimiento { get; set; }
        public string? Telefono { get; set; }

      

        public string? Localidad { get; set; }

        public string? Dni { get; set; }

        public string? Genero { get; set; }

        public string? ObraSocial { get; set; }



     


    }
}
