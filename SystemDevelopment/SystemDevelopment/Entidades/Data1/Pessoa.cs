using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SystemDevelopment.Entidades.Data1
{
    [Table("Pessoa")]
    public class Pessoa
    {
        [Key]
        [Column("Id")]
        public long Id { get; set; }
        [Column("Nome")]
        public string Nome { get; set; }
        [Column("Idade")]
        public int Idade { get; set; }
        [Column("Endereco")]
        public string Endereco { get; set; }
        [Column("Complemento")]
        public string Complemento { get; set; }
        [Column("Numero")]
        public int Numero { get; set; }
        [Column("Bairro")]
        public string Bairro { get; set; }
        [Column("Cep")]
        public string Cep { get; set; }
        [Column("DataNascimento")]
        public DateTime DataNascimento { get; set; }
        [Column("DataCadastro")]
        public DateTime DataCadastro { get; set; }
        [Column("Status")]
        public bool Status { get; set; }
        
        public ICollection<Models.Data1.Telefone> Telefones { get; set; }
    }
}