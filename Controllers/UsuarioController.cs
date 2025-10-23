using MeowColonThree.Models;
using MeowColonThree.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace MeowColonThree.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _UsuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio UsuarioRepositorio)
        {
            _UsuarioRepositorio = UsuarioRepositorio;
        }

        public IActionResult Index()
        {
            List<UsuarioModel> Usuarios = _UsuarioRepositorio.BuscarTodos();
            return View(Usuarios);
        }
        //Fazendo isso pra ver se resolve
        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }
        //Maybe it just mess things up
        [HttpPost]
        public IActionResult Criar(UsuarioModel Usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _UsuarioRepositorio.Adicionar(Usuario);
                    TempData["MensagemSucesso"] = "yayyyy you are now a parent!!!";
                    return RedirectToAction("Index");
                }

            }
            catch (System.Exception err)
            {
                TempData["MensagemErro"] = $"oh fuck. {err.Message}";
                return RedirectToAction("Index");
            }

            return View(Usuario);
        }
        public IActionResult Alterar(UsuarioModel Usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                _UsuarioRepositorio.Atualizar(Usuario);
                TempData["MensagemSucesso"] = "congratulations you are now a parent AGAIN!!!!";
                return RedirectToAction("Index");
                }

                return View("Editar", Usuario);
            }
            catch (System.Exception err)
            {
                TempData["MensagemErro"] = $"oh shit. {err.Message}";
                return RedirectToAction("Index");
            }

        }
        public IActionResult Editar(int id)
        {
            UsuarioModel Usuario = _UsuarioRepositorio.ListarPorId(id);
            return View(Usuario);
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            UsuarioModel Usuario = _UsuarioRepositorio.ListarPorId(id);
            return View(Usuario);
        }
        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _UsuarioRepositorio.Apagar(id);
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
