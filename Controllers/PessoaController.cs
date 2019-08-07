using AspNetCoreMvcControllersActions.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcControllersActions.Controllers
{
    public class PessoaController : Controller
    {
        public IActionResult Formulario()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Formulario(Pessoa pessoa)
        {
            return View("Detalhes", pessoa);
            
        }

    }
}
