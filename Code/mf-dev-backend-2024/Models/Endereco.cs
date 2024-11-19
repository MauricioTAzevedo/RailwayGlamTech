using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2024.Models
{
    [Table("Enderecos")]
    public class Endereco
    {
        [Key]
        public int IdEndereco { get; set; }

        [Required(ErrorMessage = "O CEP é obrigatório.")]
        [MaxLength(8, ErrorMessage = "O CEP pode ter no máximo 8 caracteres.")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "O logradouro é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O logradouro pode ter no máximo 100 caracteres.")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O número é obrigatório.")]
        [MaxLength(10, ErrorMessage = "O número pode ter no máximo 10 caracteres.")]
        public string Numero { get; set; }

        [MaxLength(50, ErrorMessage = "O complemento pode ter no máximo 50 caracteres.")]
        public string? Complemento { get; set; }

        [Required(ErrorMessage = "O bairro é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O bairro pode ter no máximo 50 caracteres.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "A cidade é obrigatória.")]
        [MaxLength(50, ErrorMessage = "A cidade pode ter no máximo 50 caracteres.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O estado é obrigatório.")]
        [MaxLength(2, ErrorMessage = "O estado pode ter no máximo 2 caracteres.")]
        public string Estado { get; set; }
    }
}
