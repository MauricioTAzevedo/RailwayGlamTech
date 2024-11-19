using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2024.Models
{
    [Table("Notificacoes")] 
    public class Notificacao
    {
        [Key]
        public int NotificacaoId { get; set; }

        [Required]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "A mensagem é obrigatória.")]
        [MaxLength(500, ErrorMessage = "A mensagem pode ter no máximo 500 caracteres.")]
        public string Mensagem { get; set; }

        public void EnviarNotificacao() { }
    }
}
