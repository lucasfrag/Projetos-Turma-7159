using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using MVC_CRUD.Models;

namespace MVC_CRUD.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Login() {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario u) {
            Usuario usuarioEncontrado = UsuarioBD.ValidarLogin(u);

            if(usuarioEncontrado != null) {
                HttpContext.Session.SetInt32("id", usuarioEncontrado.id);
                HttpContext.Session.SetString("nome", usuarioEncontrado.nome);
                HttpContext.Session.SetInt32("tipo", usuarioEncontrado.tipo);

                return RedirectToAction("Cadastro", "Carro");
            } else {
                ViewBag.Mensagem = "Falha no login!";
                return View();
            }
        }

        public IActionResult Logout() {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Usuario");
        }
    }
}