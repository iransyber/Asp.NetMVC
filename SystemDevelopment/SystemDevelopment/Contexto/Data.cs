using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using SystemDevelopment.Controllers;

namespace SystemDevelopment.Contexto
{
    public class Data : BaseController
    {
        protected DBcontexto Contexto { get; set; }

        public Data()
        {
            Contexto = new DBcontexto(ConfigurationManager.AppSettings["Data1"]);
        }
    }
}