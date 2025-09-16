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
            try
            {
                if (ModelState.IsValid)
                {
                _contatoRepositorio.Atualizar(contato);
                TempData["MensagemSucesso"] = "congratulations you are now a parent AGAIN!!!!";
                return RedirectToAction("Index");
                }

                return View("Editar", contato);
            }
            catch (System.Exception err)
            {
                TempData["MensagemErro"] = $"oh shit. {err.Message}";
                return RedirectToAction("Index");
            }

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
            try
            {
                bool apagado = _contatoRepositorio.Apagar(id);
                if (apagado)
                    TempData["MensagemSucesso"] = "Yayyyy, you just did a murder!!!!";
                else
                    TempData["MensagemErro"] = "BUT THE EARTH REFUSED TO DIE.";

                return RedirectToAction("Index");
            }
            catch (System.Exception err)
            {
                TempData["MensagemErro"] = $"oh no. {err.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
