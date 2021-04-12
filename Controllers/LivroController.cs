using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;


namespace Biblioteca.Controllers
{

    public class LivroController : Controller
    {

        public IActionResult Cadastro()
        {
            Autenticacao.CheckLogin(this);

            if (HttpContext.Session.GetString("Nivel") == "Usuario")
            {
                return RedirectToAction("Login", "Home");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Livro l)
        {

            LivroService livroService = new LivroService();

            if (l.Id == 0)
            {
                livroService.Inserir(l);
            }
            else
            {
                livroService.Atualizar(l);
            }

            return RedirectToAction("Listagem");
        }

        [HttpGet]
        public IActionResult Listagem(int p = 1)
        {

            Autenticacao.CheckLogin(this);

            if (HttpContext.Session.GetString("Nivel") == "Usuario")
            {
                return RedirectToAction("Login", "Home");
            }

            int quantidadePorPagina = 10;

            LivroService ls = new LivroService();

            ICollection<Livro> livros = ls.Lista(p, quantidadePorPagina);

            int quantidadeRegistros = ls.CountLivros();

            ViewData["Paginas"] = (int)Math.Ceiling((double)quantidadeRegistros / quantidadePorPagina);


            return View(livros);
        }

        [HttpPost]
        public IActionResult Listagem(string tipoFiltro, string filtro)
        {

            FiltrosLivros objFiltro = null;
            if (!string.IsNullOrEmpty(filtro))
            {
                objFiltro = new FiltrosLivros();
                objFiltro.Filtro = filtro;
                objFiltro.TipoFiltro = tipoFiltro;
            }
            LivroService livroService = new LivroService();
            ICollection<Livro> livros = livroService.ListarTodos(objFiltro);

            if (livros.Count == 0)
            {
                ViewData["MensagemL"] = "Nenhum registro encontrado";
            }
            return View(livros);

        }

        public IActionResult Edicao(int id)
        {
            Autenticacao.CheckLogin(this);

            if (HttpContext.Session.GetString("Nivel") == "Usuario")
            {
                return RedirectToAction("Login", "Home");
            }

            LivroService ls = new LivroService();
            Livro l = ls.ObterPorId(id);
            return View(l);
        }
    }
}