using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationDelaJob.Controllers
{
    public class VagasController : Controller
    {
        public IActionResult Vagas()
        {
            return View();
        }
    }
}
