using System.ComponentModel.DataAnnotations;

namespace EjemploCrudMVC5AngJs.Models
{
    public class VEHICULOS
    {
        [Key]
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Anio { get; set; }
    }
}