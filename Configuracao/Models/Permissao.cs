﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Permissao
    {
        public int Id_permi { get; set; }
        public string Descricao { get; set; }
        public List<GrupoUsuario> grupos{ get; set; }    
    }
}
