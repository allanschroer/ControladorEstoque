using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ControladorEstoque.Models;

namespace ControladorEstoque.Data
{
    public class ControladorEstoqueContext : DbContext
    {
        public ControladorEstoqueContext (DbContextOptions<ControladorEstoqueContext> options)
            : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Entrada> Entrada { get; set; }
        public DbSet<Saida> Saida { get; set; }
    }
}
