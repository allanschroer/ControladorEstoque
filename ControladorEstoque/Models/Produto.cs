using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControladorEstoque.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Name { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public double Quantidade { get; set; }
        
        public Produto() { }
        public Produto(int id, int codigo, string name, string descricao, double valor, double quantidade)
        {
            Id = id;
            Codigo = codigo;
            Name = name;
            Descricao = descricao;
            Valor = valor;
            Quantidade = quantidade;
        }



    }
}
