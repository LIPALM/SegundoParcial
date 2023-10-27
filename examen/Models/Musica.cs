using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Musica
    {
        [Key]
        public int idMusica { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int NumeroReproduciones { get; set; }
        public int idDisco { get; set; }

    }
}