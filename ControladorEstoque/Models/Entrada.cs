using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControladorEstoque.Models
{
    public class Entrada
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public double ValorCompra { get; set; }
        public double Quantidade { get; set; }

        public Entrada() { }

        public Entrada (int produtoId, double valorCompra, double quantidade)
        {
            ProdutoId = produtoId;
            ValorCompra = valorCompra;
            Quantidade = quantidade;
        }
    }
}
