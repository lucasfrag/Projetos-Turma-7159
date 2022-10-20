using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using MVC_CRUD.Models;

namespace MVC_CRUD.Controllers
{
    public class CarroController : Controller
    {
        public IActionResult TestarConexao() {
            ViewBag.mensagem = CarroBD.TestarConexao();
            return View();
        }

        public IActionResult Cadastro()
        {
            if(HttpContext.Session.GetInt32("id") == null) {
                return RedirectToAction("Login", "Usuario");
            }

            if(HttpContext.Session.GetInt32("tipo") != 1) {
                return RedirectToAction("Privacy", "Home");
            }

            return View();
        }

        
        [HttpPost]
        public IActionResult Cadastro(Carro novoCarro)
        {
            CarroBD.Inserir(novoCarro);
            //ViewBag.Mensagem = "Cadastro concluído com sucesso!";
            ViewBag.marca = novoCarro.marca;
            ViewBag.ano = novoCarro.ano;
            ViewBag.cor = novoCarro.cor;
            ViewBag.valor = novoCarro.valor;


            return View("Confirmacao");
        }
        
        public IActionResult Listagem()
        {
            List<Carro> listaCompleta = CarroBD.Listar();
            //ViewBag.Total = ListaCarro.Calcular();
            return View(listaCompleta);
        }

        
        public IActionResult Editar(int id) {
            Carro carro = CarroBD.BuscarPorId(id);
            return View(carro);
        }

        [HttpPost]
        public IActionResult Editar(Carro carro) {
            CarroBD.Atualizar(carro);
            return RedirectToAction("Listagem");
        }

        public IActionResult Remover(int id) {
            CarroBD.Remover(id);
            return RedirectToAction("Listagem");
        }
    }
}