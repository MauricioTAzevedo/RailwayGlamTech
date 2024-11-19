using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2024.Models
{
    [Table("Pagamentos")]
    public class Pagamento
    {
        [Key]
        public int PagamentoId { get; set; }

        [Required(ErrorMessage = "O valor do pagamento é obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor do pagamento deve ser maior que zero.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        // Status e enum StatusPagamento foram removidos

        public void RealizarPagamento() { }
        public void EmitirRecibo() { }
    }
}
