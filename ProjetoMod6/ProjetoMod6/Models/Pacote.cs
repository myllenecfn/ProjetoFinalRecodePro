using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ProjetoMod6.Models
{
    public class Pacote
    {
        [Key]
        public int IdPacote { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public string PrecoPacote { get; set; }

        [JsonIgnore]
        public List<Compra> Compras { get; set; }
    }
}
