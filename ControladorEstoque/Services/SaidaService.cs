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
        public readonly ControladorEstoqueContext _context;

        public SaidaService(ControladorEstoqueContext context)
        {
            context = _context;
        }

        public List<Saida> FindAll()
        {
            return _context.Saida.ToList();
        }
    }
}
