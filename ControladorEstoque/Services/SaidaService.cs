using ControladorEstoque.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControladorEstoque.Models;

namespace ControladorEstoque.Services
{
    public class SaidaService
    {
        private readonly ControladorEstoqueContext _context;

        public SaidaService(ControladorEstoqueContext context)
        {
            _context = context;
        }

        public List<Produto> GetProdutos()
        {
            return _context.Produto.ToList();
        }

        public List<Saida> FindAll()
        {
            return _context.Saida.ToList();
        }
    }
}
