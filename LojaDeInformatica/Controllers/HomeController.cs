using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaDeInformatica.DAO;
using LojaDeInformatica.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LojaDeInformatica.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Logado = HelperControllers.VerificaUserLogado(HttpContext.Session);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "O que é esse site?";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Onde você pode nos encontrar?";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}