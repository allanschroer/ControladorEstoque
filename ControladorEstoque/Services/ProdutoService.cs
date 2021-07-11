using ControladorEstoque.Data;
using ControladorEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControladorEstoque.Services
{
    public class ProdutoService
    {
        private readonly ControladorEstoqueContext _context;

        public ProdutoService(ControladorEstoqueContext context)
        {
            _context = context;
        }

        public List<Produto> FindAll()
        {
            return _context.Produto.OrderBy(x => x.Name).ToList();
        }
    }
}
