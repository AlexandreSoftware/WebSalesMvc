using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departamentos = new List<Department> {
                new Department(1,"Recursos Humanos"),
                new Department(2,"TI"),
                new Department(3,"Contabilidade")
            };
            departamentos.Find((x) => x.id(1)).addSeller(new Seller());
            return View(departamentos);
        }
    }
}