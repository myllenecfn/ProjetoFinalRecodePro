using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ProjetoMod6.Models
{
    public class Usuario
    {

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        [JsonIgnore]
        public List<Compra> Compras { get; set; }
    }
}

