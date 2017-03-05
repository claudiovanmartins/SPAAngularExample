using SPAAngularExample.Models.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPAAngularExample.Controllers
{
    public class HomeController : Controller
    {
        private CadastroFactory cadastroFactory = new CadastroFactory();
        // GET: Home
        public ActionResult Index()
        {
            return View("Index","",cadastroFactory.BuildCadastro());
        }
    }
}