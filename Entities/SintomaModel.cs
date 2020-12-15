﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SintomaModel
    {
        public int SintomaId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public List<OleoModel> Oleos { get; set; }
    }
}
