using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LojaDeInformatica.Models
{
    public class ProdutoViewModel : PadraoViewModel
    {
        /// <summary>
        /// Imagem recebida do form pelo Controller
        /// </summary>
        public IFormFile Imagem { get; set; }

        /// <summary>
        /// Imagem em bytes pronta para ser salva
        /// </summary>
        /// <returns></returns>
        public byte[] ImagemEmByte { get; set; }

        /// <summary>
        /// Imagem usada para ser enviada ao form no formato para ser exibida
        /// </summary>
        public string ImagemEmBase64
        {
            get
            {
                if (ImagemEmByte != null)
                    return Convert.ToBase64String(ImagemEmByte);
                else
                    return string.Empty;
            }
        }

        public string Descricao { get; set; }

        public int Id_Categoria { get; set; }

        public string Desc_Categoria { get; set; }

        public decimal Preco { get; set; }

        public int Id_Marca { get; set; }

        public string Desc_Marca { get; set; }

        public int Qtd_Estoque { get; set; }

        //public int Qtd_Reservado { get; set; }
    }
}
