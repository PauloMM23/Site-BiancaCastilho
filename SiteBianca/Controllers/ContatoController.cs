using Microsoft.AspNetCore.Mvc;
using SiteBianca.Models;

namespace SiteBianca.Controllers
{
    public class ContatoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Enviar(ContatoViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Aqui você pode enviar o email ou salvar os dados
                ViewBag.Mensagem = "Mensagem enviada com sucesso!";
                ModelState.Clear(); // Limpa o formulário após envio
                return View("Index");
            }
            return View("Index", model);
        }
    }
}
