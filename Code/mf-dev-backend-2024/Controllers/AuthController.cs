using Microsoft.AspNetCore.Mvc;
using mf_dev_backend_2024.Models;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace mf_dev_backend_2024.Controllers
{
    public class AuthController : Controller
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            System.Diagnostics.Debug.WriteLine($"Email: {email}, Senha: {senha}");

            var usuario = _context.Usuarios
                .FirstOrDefault(u => u.Email == email && u.Senha == senha);

            if (usuario != null)
            {
                TempData["UserName"] = usuario.Nome;
                return RedirectToAction("Register"); 
            }
            else
            {
                ViewBag.ErrorMessage = "Email ou senha inválidos.";
                return View();
            }
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(string nome, string email, string senha, string tipoUsuario, string CEP, string Logradouro, string Numero, string? Complemento, string Bairro, string Cidade, string Estado, IFormFile foto)
        {
            byte[] fotoBytes = null;
            if (foto != null)
            {
                using (var ms = new MemoryStream())
                {
                    await foto.CopyToAsync(ms);
                    fotoBytes = ms.ToArray();
                }
            }

            if (tipoUsuario == "cliente")
            {
                var novoCliente = new Cliente
                {
                    Nome = nome,
                    Email = email,
                    Senha = senha,
                    FotoPerfil = fotoBytes,
                    CEP = CEP,
                    Logradouro = Logradouro,
                    Numero = Numero,
                    Complemento = Complemento,
                    Bairro = Bairro,
                    Cidade = Cidade,
                    Estado = Estado
                };
                _context.Clientes.Add(novoCliente);
            }
            else if (tipoUsuario == "profissional")
            {
                var novoProfissional = new Profissional
                {
                    Nome = nome,
                    Email = email,
                    Senha = senha,
                    FotoPerfil = fotoBytes,
                    CEP = CEP,
                    Logradouro = Logradouro,
                    Numero = Numero,
                    Complemento = Complemento,
                    Bairro = Bairro,
                    Cidade = Cidade,
                    Estado = Estado
                };
                _context.Profissionais.Add(novoProfissional);
            }

            await _context.SaveChangesAsync();

            return RedirectToAction("Login");
        }
    }
}
