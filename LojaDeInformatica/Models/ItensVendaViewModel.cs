using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaDeInformatica.Models
{
    public class ItensVendaViewModel:PadraoViewModel
    {
        public int Id_Venda { get; set; }

        public int Id_Produto { get; set; }

        public int Quantidade { get; set; }

        public decimal Preco { get; set; }
    }
}
