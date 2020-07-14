using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaDeInformatica.DAO;
using LojaDeInformatica.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace LojaDeInformatica.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FazerLogin(string usuario, string senha)
        {
            /*                         
             -se for igual a  1 vai logar
             -se for igual a  0 senha invalida
             -se for igual a -1 usuario não cadastrado
             */
            ClienteDAO dao = new ClienteDAO();
            ClienteViewModel clienteLogado = new ClienteViewModel();
            if (dao.TestaUsuarioSenha(usuario, senha) == 1)
            {
                HttpContext.Session.SetString("Logado", "true");
                ViewBag.Logado = HelperControllers.VerificaUserLogado(HttpContext.Session);
                clienteLogado = dao.ConsultaClienteLogado(usuario);

                string logClienteJson = JsonConvert.SerializeObject(clienteLogado);
                HttpContext.Session.SetString("usuario", logClienteJson);

                return RedirectToAction("index", "Home");
            }
            else if(dao.TestaUsuarioSenha(usuario, senha) == 0)
            {
                ViewBag.Erro = "Senha inválida!!";
                return View("index");
            }
            else
            {
                ViewBag.Erro = "Usuario inválido!!";
                return View("index");
            }
        }

        public IActionResult LogOff()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("index");
        }

        


    }
}