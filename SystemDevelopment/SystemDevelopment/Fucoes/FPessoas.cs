using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Results;
using System.Web.Mvc;
using SystemDevelopment.Contexto;
using SystemDevelopment.Interfaces;
using AutoMapper;

namespace SystemDevelopment.Fucoes
{
    public class FPessoas : Data, IPessoa
    {
        public IEnumerable<Models.Data1.Pessoa> GetAllPessoa()
        {   
            var pessoas = Contexto.Pessoas.ToList();
            var pesson = Mapper.Map<List<Models.Data1.Pessoa>>(pessoas);
            return pesson;
        }
    }
}