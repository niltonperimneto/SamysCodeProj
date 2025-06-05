using MeowColonThree.Models;
using MeowColonThree.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace MeowColonThree.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;

        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }
        //Fazendo isso pra ver se resolve
        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }
        //Maybe it just mess things up
        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Index");
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult ApagarConfirmacao()
        {
            return View();
        }
    }
}
