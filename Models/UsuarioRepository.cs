using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MySqlConnector;
using Biblioteca.Controllers;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Models
{
    public class UsuarioRepository
    {
        public void Inserir(Usuario u)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Usuario.Add(u);
                bc.SaveChanges();
            }
        }

        public void Atualizar(Usuario u)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                Usuario usuario = bc.Usuario.Find(u.IdUsuario);
                usuario.Nome = u.Nome;
                usuario.Telefone = u.Telefone;
                usuario.Email = u.Email;
                usuario.Nascimento = u.Nascimento;
                usuario.Login = u.Login;
                usuario.Senha = u.Senha;
                usuario.Nivel = u.Nivel;

                bc.SaveChanges();
            }
        }

        public ICollection<Usuario> ListarTodos(FiltrosUsuario filtro = null)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                IQueryable<Usuario> query;

                if (filtro != null)
                {
                    //definindo dinamicamente a filtragem
                    switch (filtro.TipoFiltro)
                    {
                        case "Nome":
                            query = bc.Usuario.Where(u => u.Nome.Contains(filtro.Filtro));
                            break;

                        case "Email":
                            query = bc.Usuario.Where(u => u.Email.Contains(filtro.Filtro));
                            break;

                        default:
                            query = bc.Usuario;
                            break;
                    }
                }
                else
                {
                    // caso filtro não tenha sido informado
                    query = bc.Usuario;
                }

                //ordenação padrão
                return query.OrderBy(u => u.Nome).ToList();
            }
        }

        public Usuario ObterPorId(int IdUsuario)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Usuario.Find(IdUsuario);
            }
        }

        public Usuario ValidarLogin(Usuario u)
        {

            using (BibliotecaContext bc = new BibliotecaContext())
            {
                var usuario = bc.Usuario.FirstOrDefault(user => user.Login == u.Login && user.Senha == u.Senha);

                return usuario;
            }
        }

        public void Excluir(Usuario u)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Usuario.Remove(u);
                bc.SaveChanges();
            }
        }

    }
}