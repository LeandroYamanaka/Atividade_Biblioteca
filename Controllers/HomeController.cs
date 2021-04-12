using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Biblioteca.Models;
using Microsoft.AspNetCore.Http;

namespace Biblioteca.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Autenticacao.CheckLogin(this);
            return View();
        }

        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario u)
        {
            UsuarioRepository user = new UsuarioRepository();
            Usuario usuarioSessao = new Usuario();
            usuarioSessao = user.ValidarLogin(u);

            if (usuarioSessao != null)
            {
                HttpContext.Session.SetInt32("IdUsuario", usuarioSessao.IdUsuario);
                HttpContext.Session.SetString("Login", usuarioSessao.Login);
                HttpContext.Session.SetString("Senha", usuarioSessao.Senha);
                HttpContext.Session.SetString("Nivel", usuarioSessao.Nivel);

                return RedirectToAction("Index");

            }
            else
            {

                ViewData["Login"] = "Falha no Login!";
                return View();
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Login");
        }
        public IActionResult Privacy()
        {
            return View();
        }

    }
}
