using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControladorEstoque.Models.ViewModels;
using ControladorEstoque.Services;

namespace ControladorEstoque.Controllers
{
    public class SaidasController : Controller
    {
        //Injeção de dependencia na classse, para que esse controler dependa do serviço de saida
        private readonly SaidaService _saidaService;
        private readonly ProdutoService _produtoService;
        public SaidasController(SaidaService saidaService, ProdutoService produtoService)
        {
            _produtoService = produtoService;
            _saidaService = saidaService;
        }

        public IActionResult Index() // Chama controlador
        {
            var list = _saidaService.FindAll(); // chama model
            return View(list); // retorna a view
        }
        public IActionResult Create()
        {
            var produtos = _produtoService.FindAll();
            var viewModel = new SaidaFormViewModel { Name = produtos };
            return View(viewModel);
        }
    }
}
