using System.ComponentModel.DataAnnotations;

namespace BlazorWasmOrcamento.Models
{
    public class Orcamento
    {

        public Guid Id { get; set; }
        [Required(ErrorMessage = "Informe o nome do Cliente")]
        public string Cliente { get; set; } = string.Empty;
        [Required(ErrorMessage = "Informe o veículo")]
        public string Veiculo { get; set; } = string.Empty;
        public string Placa { get; set; } = string.Empty;
        public string Chassi { get; set; } = string.Empty;
        public List<Produto>? Produtos { get; set; } = [];
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;

    }
}
