using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControladorEstoque.Data;

namespace ControladorEstoque.Models.ViewModels
{
    public class SaidaFormViewModel
    {
        public Saida Saida { get; set; }
        public ICollection<Produto> Name { get; set; }

        /*using (var context = new ControladorEstoqueContext())
        {

        }
        */
    }
}
