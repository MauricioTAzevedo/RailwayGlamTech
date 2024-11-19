using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2024.Models
{
    [Table("Servicos")]
    public class Servicos
    {
        [Key]
        public int idServicos { get; set; }

        [Required(ErrorMessage = "Servicos de Agendamentos")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "A descriçaõ e obrigatorio.")]
        [DataType(DataType.Time)]
        public string Descrição { get; set; }  

        [Required(ErrorMessage = "Preço.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preço { get; set; }


     
    }
}