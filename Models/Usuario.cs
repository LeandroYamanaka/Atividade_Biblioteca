﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public partial class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Nascimento { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nivel { get; set; }
    }
}
