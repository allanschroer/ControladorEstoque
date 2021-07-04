using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControladorEstoque.Services;

namespace ControladorEstoque.Controllers
{
    public class SaidasController : Controller
    {
        //Injeção de dependencia na classse, para que esse controler dependa do serviço de saida
        private readonly SaidaService _sellerService;
        public SaidasController(SaidaService saidaService)
        {
            _sellerService = saidaService;
        }

        public IActionResult Index() // Chama controlador
        {
            var list = _sellerService.FindAll(); // chama model
            return View(list); // retorna a view
        }
    }
}
