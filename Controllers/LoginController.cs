using MeowColonThree.Models;
using MeowColonThree.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace MeowColonThree.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}