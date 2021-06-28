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

        public DbSet<ControladorEstoque.Models.Produto> Produto { get; set; }
    }
}
