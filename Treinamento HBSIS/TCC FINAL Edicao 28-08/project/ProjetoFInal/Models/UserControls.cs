﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoFInal.Models
{
    public class UserControls
    {
        public bool Ativo { get; set; } = true;
        public int UsuarioCriacao { get; set; } = 1;
        public int UsuarioAlteracao { get; set; } = 1;
        public DateTime DataCricacao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;


    }
}