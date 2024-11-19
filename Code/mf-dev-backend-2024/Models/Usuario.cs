using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2024.Models
{
    [Table("Usuarios")]
    public class Usuario:Endereco
    {
        public enum StatusUsuario
        {
            Ativo,
            Inativo
        }

        public enum CategoriaUsuario
        {
            Profissional,
            Cliente
        }

        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public StatusUsuario Status { get; set; }
        public CategoriaUsuario Categoria { get; set; }
        public byte[] FotoPerfil { get; set; }
    }
}
