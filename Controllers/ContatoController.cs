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
            List<ContatoModel> contatos = _contatoRepositorio.BuscarTodos();
            return View(contatos);
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
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRepositorio.Adicionar(contato);
                    TempData["MensagemSucesso"] = "yayyyy you are now a parent!!!";
                    return RedirectToAction("Index");
                }

            }
            catch (System.Exception err)
            {
                TempData["MensagemErro"] = $"oh fuck. {err.Message}";
                return RedirectToAction("Index");
            }

            return View(contato);
        }
        public IActionResult Alterar(ContatoModel contato)
        {
            if (ModelState.IsValid)
            {
                _contatoRepositorio.Atualizar(contato);
                return RedirectToAction("Index");
            }

            return View("Editar", contato);
        }
        public IActionResult Editar(int id)
        {
            ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            return View(contato);
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            return View(contato);
        }
        public IActionResult Apagar(int id)
        {
            _contatoRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }
    }
}
