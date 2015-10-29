using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystemDevelopment.Entidades.Data1
{
    public class Telefone
    {
        public long Id { get; set; }
        public long PessoaId { get; set; }
        public string TelefoneMumero { get; set; }
        public bool Ativo { get; set; }
    }
}