using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControladorEstoque.Models
{
    public class Saida
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public double ValorVenda { get; set; }
        public double Quantidade { get; set; }

        public Saida(int produtoId, double valorVenda, double quantidade)
        {
            ProdutoId = produtoId;
            ValorVenda = valorVenda;
            Quantidade = quantidade;
        }
    }
}
