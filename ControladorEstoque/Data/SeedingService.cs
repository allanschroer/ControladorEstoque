using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControladorEstoque.Models;
using Microsoft.EntityFrameworkCore;

namespace ControladorEstoque.Data
{
    public class SeedingService
    {
        private  ControladorEstoqueContext _contex;

        public SeedingService(ControladorEstoqueContext context)
        {
            _contex = context;
        }

        public void Seed()
        {

            if (_contex.Produto.Any() || _contex.Entrada.Any() || _contex.Entrada.Any())
            {
                return; //DB ja foi populado.
            }

            Produto p1 = new Produto( 1, "Chaleira elétrica", "Chaleira eletrica vermelha 220V", 69.90, 20);
            Produto p2 = new Produto( 2, "Chaleira elétrica", "Chaleira eletrica vermelha 110V", 69.90, 20);
            Produto p3 = new Produto( 3, "Geladeira", "Geladedira 420 litros", 1769.90, 20);
            Produto p4 = new Produto( 4, "Notebook Dell", "I3 8ª geração, 8gb ddr4", 2199.90, 20);
            Produto p5 = new Produto( 5, "Cadeira gamer", "Cadeira gamer vermelha", 899.90, 20);

            Entrada e1 = new Entrada( 0, 30, 5);
            Entrada e2 = new Entrada( 1, 30, 5);
            Entrada e3 = new Entrada( 2, 1200, 5);
            Entrada e4 = new Entrada( 3, 1100, 5);
            Entrada e5 = new Entrada( 4, 399.90, 5);

            Saida s1 = new Saida( 0, 30, 2);
            Saida s2 = new Saida( 1, 30, 3);
            Saida s3 = new Saida( 2, 1200, 6);
            Saida s4 = new Saida( 3, 1100, 11);
            Saida s5 = new Saida( 4, 399.90, 9);

            try
            {
                _contex.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Produto ON");
                _contex.Produto.AddRange(p1, p2, p3, p4, p4, p5);
                _contex.SaveChanges();
                _contex.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Produto OFF");


            }
            finally { _contex.Database.CloseConnection(); }

            try
            {
                _contex.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Entrada ON");
                _contex.Entrada.AddRange(e1, e2, e3, e4, e4, e5);
                _contex.SaveChanges();
                _contex.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Entrada OFF");
            }
            finally { _contex.Database.CloseConnection(); }
            try
            {
                _contex.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Saida ON");
                _contex.Saida.AddRange(s1, s2, s3, s4, s4, s5);
                _contex.SaveChanges();
                _contex.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Saida OFF");
            }
            finally { _contex.Database.CloseConnection(); }

            /*
            _contex.Produto.AddRange(p1, p2, p3, p4, p4, p5);
            _contex.Entrada.AddRange(e1, e2, e3, e4, e4, e5);
            _contex.Saida.AddRange(s1, s2, s3, s4, s4, s5);


            _contex.SaveChanges();

            /*
    public int Id { get; set; }
    public int Codigo { get; set; }
    public string Name { get; set; }
    public string Descricao { get; set; }
    public double Valor { get; set; }
    public double Quantidade { get; set; }
             */

        }
    }
}
