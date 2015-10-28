using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SystemDevelopment.Interfaces
{
    public interface IPessoa
    {
        IEnumerable<Models.Data1.Pessoa> GetAllPessoa();
    }
}