using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaDeInformatica.Models
{
    public class VendaViewModel:PadraoViewModel
    {
        public DateTime Data_Venda { get; set; }

        public int Id_Cliente { get; set; }

        public DateTime Data_Entrega { get; set; }

        public int Id_EstadoEntrega { get; set; }
    }
}
