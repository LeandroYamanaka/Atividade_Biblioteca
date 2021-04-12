using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Biblioteca.Models;
using Microsoft.AspNetCore.Http;
using MySql.Data.MySqlClient;

namespace Biblioteca.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult CadastroUsuario()
        {
            Autenticacao.CheckLogin(this);

            if (HttpContext.Session.GetString("Nivel") == "Usuario")
            {
                return RedirectToAction("Login", "Home");
            }

            return View();
        }

        [HttpPost]
        public IActionResult CadastroUsuario(Usuario u)
        {

            UsuarioRepository usuariorepository = new UsuarioRepository();

            if (u.IdUsuario == 0)
            {
                usuariorepository.Inserir(u);
            }
            else
            {
                usuariorepository.Atualizar(u);
            }

            return RedirectToAction("Listadeusuarios");
        }

        public IActionResult Listadeusuarios(string tipoFiltro, string filtro)
        {
            Autenticacao.CheckLogin(this);

            if (HttpContext.Session.GetString("Nivel") == "Usuario")
            {
                return RedirectToAction("Login", "Home");
            }

            FiltrosUsuario objFiltro = null;
            if (!string.IsNullOrEmpty(filtro))
            {
                objFiltro = new FiltrosUsuario();
                objFiltro.Filtro = filtro;
                objFiltro.TipoFiltro = tipoFiltro;
            }
            UsuarioRepository usuariorepository = new UsuarioRepository();
            return View(usuariorepository.ListarTodos(objFiltro));
        }

        public IActionResult Editar(int IdUsuario)
        {
            Autenticacao.CheckLogin(this);

            if (HttpContext.Session.GetString("Nivel") == "Usuario")
            {
                return RedirectToAction("Login", "Home");
            }

            UsuarioRepository user = new UsuarioRepository();
            Usuario u = user.ObterPorId(IdUsuario);
            return View(u);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Login");
        }

        public IActionResult Excluir(int IdUsuario)
        {
            Usuario user = new Usuario();
            UsuarioRepository u = new UsuarioRepository();
            user = u.ObterPorId(IdUsuario);
            u.Excluir(user);

            return RedirectToAction("Listagem");
        }

    }
}