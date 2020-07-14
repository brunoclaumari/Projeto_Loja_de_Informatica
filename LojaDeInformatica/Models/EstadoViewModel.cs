using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaDeInformatica.Models
{
    public class EstadoViewModel:PadraoViewModel
    {
        public string Estado { get; set; }
        public string Descricao { get; set; }
        public int Id_Regiao { get; set; }
    }
}
