using System;
using System.Collections.Generic;

namespace SystemDevelopment.Models.Data1
{
    public class Pessoa
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Status { get; set; }
        public ICollection<Telefone> Telefone { get; set; }
    }
}