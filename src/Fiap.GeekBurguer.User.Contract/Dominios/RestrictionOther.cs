﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.GeekBurguer.Users.Contract.Dominios
{
    public class RestrictionOther
    {
        public RestrictionOther(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
    }
}
