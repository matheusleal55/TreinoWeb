using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAplicaçãoTreino.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {

            string[] alunos =
            {
                "José",
                "João",
                "maria"

            };
            return View(alunos);
        }
    }
}