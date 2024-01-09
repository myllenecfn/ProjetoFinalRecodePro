using System.ComponentModel.DataAnnotations;

namespace ProjetoMod6.Models
{
    public class Compra
    {
        [Key]
        public int Id { get; set; }
        public string Data_compra { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int PacoteId { get; set; }
        public Pacote pacote { get; set; }

    }
}
