using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2024.Models
{
    [Table("Estoques")] 
    public class Estoque
    {
        [Key]
        public int EstoqueId { get; set; }

        [Required(ErrorMessage = "O nome do produto é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O nome do produto pode ter no máximo 100 caracteres.")]
        public string Produto { get; set; }

        [Required(ErrorMessage = "A quantidade é obrigatória.")]
        [Range(0, int.MaxValue, ErrorMessage = "A quantidade não pode ser negativa.")]
        public int Quantidade { get; set; }

        public void AdicionarProduto() { }
        public void RemoverProduto() { }
        public void ControlarEstoque() { }
    }
}
