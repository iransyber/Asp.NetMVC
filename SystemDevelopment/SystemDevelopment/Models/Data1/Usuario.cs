using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystemDevelopment.Models.Data1
{
    public class Usuario : Pessoa
    {
        public string Senha { get; set; }
        public DateTime DataUltimoAcesso { get; set; }
        public bool Ativado { get; set; }
        public int Nivel { get; set; }
    }
}