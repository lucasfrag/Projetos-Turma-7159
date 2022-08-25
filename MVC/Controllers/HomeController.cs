using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Carro novoCarro)
        {
            Dados.ListaCarroAtual.Adicionar(novoCarro);
            //ViewBag.Mensagem = "Cadastro concluído com sucesso!";
            ViewBag.marca = novoCarro.marca;
            ViewBag.ano = novoCarro.ano;
            ViewBag.cor = novoCarro.cor;
            ViewBag.valor = novoCarro.valor;


            return View("Confirmacao");
        }

        public IActionResult Listagem()
        {
            List<Carro> listaCompleta = Dados.ListaCarroAtual.Listar();
            ViewBag.Total = Dados.ListaCarroAtual.Calcular();
            return View(listaCompleta);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
