using LojaDeInformatica.DAO;
using LojaDeInformatica.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LojaDeInformatica.Controllers
{
    public class ProdutoController : PadraoController<ProdutoViewModel>
    {
        public ProdutoController()
        {
            DAO = new ProdutoDAO();
            GeraProximoId = true;
        }

        public byte[] ConvertImageToByte(IFormFile file)
        {
            if (file != null)
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    return ms.ToArray();
                }
            else
                return null;
        }

        protected override void PreencheDadosParaView(string Operacao, ProdutoViewModel model)
        {
            base.PreencheDadosParaView(Operacao, model);
            PreparaComboDeCategoria();
            PreparaComboDeMarca();

        }

        protected override void ValidaDados(ProdutoViewModel model, string operacao)
        {
            base.ValidaDados(model, operacao);
            ProdutoDAO prDao = new ProdutoDAO();

            if (string.IsNullOrEmpty(model.Descricao))
                ModelState.AddModelError("Descricao", "Preencha a descrição");
            if (model.Preco <= 0)
                ModelState.AddModelError("preco", "Digite um valor que zero!!!");
            //if(operacao == "A")
            //{
            //    ProdutoViewModel pr = DAO.Consulta(model.Id);
            //    model.Preco = pr.Preco;
            //}

            if (model.Qtd_Estoque < 0)
                ModelState.AddModelError("Qtd_estoque", "Digite um valor para o estoque!!!");
            //if (model.Qtd_Reservado < 0)
            //    ModelState.AddModelError("Qtd_Reservado", "Digite um valor para o estoque!!!");
            //Estas debaixo são as validações das imagens!!
            if (model.Imagem == null && operacao == "I")
                ModelState.AddModelError("imagem", "Escolha uma imagem!");
            if (model.Imagem != null && model.Imagem.Length / 1024 / 1024 >= 2)
                ModelState.AddModelError("imagem", "imagem limitada a 2Mb!");
            if(ModelState.IsValid)
            {
                //na alteração, se não foi informada a imagem, mantem a que já estava
                if(operacao=="A" && model.Imagem == null)
                {
                    ProdutoViewModel prod = DAO.Consulta(model.Id);
                    model.ImagemEmByte = prod.ImagemEmByte;
                }
                else
                {
                    model.ImagemEmByte = ConvertImageToByte(model.Imagem);
                    
                }
            }
            
            if(prDao.ExisteImagem(operacao,model.ImagemEmByte)==-1)
            {
                ModelState.AddModelError("imagem", "Imagem já existe, escolha outra imagem!!");
            }
        }

        private void PreparaComboDeCategoria()
        {
            CategoriaDAO catDao = new CategoriaDAO();
            var categorias = catDao.Listagem();
            List<SelectListItem> listaCateg = new List<SelectListItem>();

            listaCateg.Add(new SelectListItem("Selecione uma categoria...", "0"));
            foreach (var cat in categorias)
            {
                SelectListItem item = new SelectListItem(cat.Descricao, cat.Id.ToString());
                listaCateg.Add(item);
            }
            ViewBag.Categoria = listaCateg;
        }


        private void PreparaComboDeMarca()
        {
            MarcaDAO mDao = new MarcaDAO();
            var marcas = mDao.Listagem();
            List<SelectListItem> listaMarcas = new List<SelectListItem>();

            listaMarcas.Add(new SelectListItem("Selecione uma marca...", "0"));
            foreach (var mar in marcas)
            {
                SelectListItem item = new SelectListItem(mar.Marca, mar.Id.ToString());
                listaMarcas.Add(item);
            }
            ViewBag.Marca = listaMarcas;
        }

        //Método para buscar os dados filtrados
        public IActionResult FiltroProduto(int id_categoria,
                        int id_marca, decimal preco)
        {
            ProdutoDAO proDAO = new ProdutoDAO();
            var lista = proDAO.FiltroProdutos(id_categoria,id_marca,preco);
            return View(lista);
        }


    }
}
