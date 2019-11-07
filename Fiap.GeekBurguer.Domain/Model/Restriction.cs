﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Fiap.GeekBurguer.Domain.Model
{
    public class Restriction : Base
    {
        public Guid UserID { get; set; }
        public string Nome { get; set; }
    }
}
