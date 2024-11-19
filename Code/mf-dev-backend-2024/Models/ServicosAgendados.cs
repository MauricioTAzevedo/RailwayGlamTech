using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2024.Models
{
    [Table("ServicosAgendados")]
    public class ServicosAgendados
    {
        [Key]
       public int idAgendamentos { get; set; }
        [Required(ErrorMessage = "Nome Do Cliente e Obrigatorio")]
        public string nomecliente { get; set; }
        [Required(ErrorMessage = "Data e Obrigatoria")] 
        public DateTime Data { get; set;}
        [Required(ErrorMessage = "Horario Obrigatorio")]
        public TimeSpan Hora { get; set;}




    }
}
