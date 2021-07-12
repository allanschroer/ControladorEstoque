using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [DataType(DataType.Currency)]
        public double Valor { get; set; }
        public double Quantidade { get; set; }
        
        public Produto() { }
        public Produto( int codigo, string name, string descricao, double valor, double quantidade)
        {
            
            Codigo = codigo;
            Name = name;
            Descricao = descricao;
            Valor = valor;
            Quantidade = quantidade;
        }



    }
}
