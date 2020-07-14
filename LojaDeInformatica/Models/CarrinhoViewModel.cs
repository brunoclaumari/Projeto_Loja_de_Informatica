using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LojaDeInformatica.Models
{
    public class CarrinhoViewModel:PadraoViewModel
    {
        public int Id_Produto { get; set; }

        public int Quantidade { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public string ImagemEmBase64 { get; set; }

        public decimal TotalCompra()
        {
            return Preco * Quantidade;
        }



    }
}
