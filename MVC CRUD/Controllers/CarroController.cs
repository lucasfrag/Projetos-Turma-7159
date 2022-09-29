using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
            return View();
        }

        /**
        [HttpPost]
        public IActionResult Cadastro(Carro novoCarro)
        {
            ListaCarro.Adicionar(novoCarro);
            //ViewBag.Mensagem = "Cadastro concluído com sucesso!";
            ViewBag.marca = novoCarro.marca;
            ViewBag.ano = novoCarro.ano;
            ViewBag.cor = novoCarro.cor;
            ViewBag.valor = novoCarro.valor;


            return View("Confirmacao");
        }

        public IActionResult Listagem()
        {
            List<Carro> listaCompleta = ListaCarro.Listar();
            ViewBag.Total = ListaCarro.Calcular();
            return View(listaCompleta);
        }

        */
        
    }
}