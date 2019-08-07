using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcControllersActions.Controllers
{
    public class OutroController : Controller
    {
        public ViewResult Index()
        {
            return View("Resultado", $"Outro controller");
        }

        public ViewResult Headers()
        {
            return View("MapaResultado", Request.Headers.ToDictionary(kvp => kvp.Key, kvp =>))
        }
    }
}
