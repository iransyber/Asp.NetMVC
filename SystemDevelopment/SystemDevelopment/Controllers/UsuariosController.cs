using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SystemDevelopment.Interfaces;

namespace SystemDevelopment.Controllers
{
    public class UsuariosController : Controller
    {
        private IPessoa _pessoa;
        //
         //GET: /Usuarios/
        public ActionResult Usuarios()
        {
            return View();
        }

        public JsonResult ListarTotos()
        {
            return Json(_pessoa.GetAllPessoa(), JsonRequestBehavior.AllowGet);
        }
	}
}