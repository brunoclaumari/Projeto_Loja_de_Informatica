using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LojaDeInformatica.DAO;
using LojaDeInformatica.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace LojaDeInformatica.Controllers
{
    public class CarrinhoController : Controller
    {

        public IActionResult Index()
        {
            ProdutoDAO dao = new ProdutoDAO();
            var listaDeProdutos = dao.Listagem();

            var carrinho = ObtemCarrinhoNaSession();

            @ViewBag.TotalCarrinho = carrinho.Sum(c => c.Quantidade);

            return View(listaDeProdutos);
        }


        public IActionResult Detalhes(int idProduto)
        {
            List<CarrinhoViewModel> carrinho = ObtemCarrinhoNaSession();

            ProdutoDAO prodDao = new ProdutoDAO();
            var modelProduto = prodDao.Consulta(idProduto);

            CarrinhoViewModel carrinhoModel = carrinho.Find(c => c.Id_Produto == idProduto);
            if (carrinhoModel == null)
            {
                carrinhoModel = new CarrinhoViewModel();
                carrinhoModel.Id_Produto = idProduto;
                carrinhoModel.Nome = modelProduto.Descricao;
                carrinhoModel.Preco = modelProduto.Preco;
                carrinhoModel.Quantidade = 0;

            }

            // preenche a imagem
            carrinhoModel.ImagemEmBase64 = modelProduto.ImagemEmBase64;
            return View(carrinhoModel);
        }

        private List<CarrinhoViewModel> ObtemCarrinhoNaSession()
        {
            List<CarrinhoViewModel> carrinho = new List<CarrinhoViewModel>();
            string carrinhoJson = HttpContext.Session.GetString("carrinho");
            if (carrinhoJson != null)
                carrinho = JsonConvert.DeserializeObject<List<CarrinhoViewModel>>(carrinhoJson);

            return carrinho;
        }

        //private List<CarrinhoViewModel> ZeraCarrinhoNaSession()
        //{
        //    List<CarrinhoViewModel> carrinho = null;
        //    string carrinhoJson = HttpContext.Session.SetString("carrinho",null);
        //    if (carrinhoJson != null)
        //        carrinho = JsonConvert.DeserializeObject<List<CarrinhoViewModel>>(carrinhoJson);

        //    return carrinho;
        //}

        private ClienteViewModel ObtemUsuarioNaSession()
        {
            ClienteViewModel clienteLogado = new ClienteViewModel();
            string usuarioJson = HttpContext.Session.GetString("usuario");
            if (usuarioJson != null)
                clienteLogado = JsonConvert.DeserializeObject<ClienteViewModel>(usuarioJson);

            return clienteLogado;
        }

        public IActionResult AdicionarCarrinho(int Id_Produto, int Quantidade)
        {
            try
            {
                List<CarrinhoViewModel> carrinho = ObtemCarrinhoNaSession();

                CarrinhoViewModel carrinhoModel = carrinho.Find(c => c.Id_Produto == Id_Produto);

                if (carrinhoModel != null && Quantidade == 0)
                {
                    //tira do carrinho
                    carrinho.Remove(carrinhoModel);
                }
                else if (carrinhoModel == null && Quantidade > 0)
                {
                    //não havia no carrinho, vamos adicionar
                    ProdutoDAO prodDao = new ProdutoDAO();
                    var modelProduto = prodDao.Consulta(Id_Produto);

                    carrinhoModel = new CarrinhoViewModel();
                    carrinhoModel.Id_Produto = Id_Produto;
                    carrinhoModel.Nome = modelProduto.Descricao;
                    carrinhoModel.Preco = modelProduto.Preco;
                    //carrinhoModel.ImagemEmBase64 = modelProduto.ImagemEmBase64;

                    carrinho.Add(carrinhoModel);
                }

                if (carrinhoModel != null)
                    carrinhoModel.Quantidade = Quantidade;

                string carrinhoJson = JsonConvert.SerializeObject(carrinho);
                HttpContext.Session.SetString("carrinho", carrinhoJson);

                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                ViewBag.Erro = "Ocorreu um erro: " + erro.Message;
                return RedirectToAction("index");
            }
        }


        public IActionResult Visualizar()
        {
            ProdutoDAO dao = new ProdutoDAO();
            var carrinho = ObtemCarrinhoNaSession();
            foreach (var item in carrinho)
            {
                var prod = dao.Consulta(item.Id_Produto);
                item.ImagemEmBase64 = prod.ImagemEmBase64;
            }

            return View(carrinho);
        }


        public IActionResult EfetuarPedido()
        {
            //Aqui será o controle de transação
            try
            {
                using (var transacao = new System.Transactions.TransactionScope())
                {
                    ClienteViewModel cliLogado = ObtemUsuarioNaSession();


                    VendaViewModel venda = new VendaViewModel();
                    venda.Data_Venda = DateTime.Now;
                    venda.Id_Cliente = cliLogado.Id;
                    venda.Data_Entrega = (DateTime.Now).AddDays(7);
                    venda.Id_EstadoEntrega = cliLogado.Id_Estado;
                    VendaDAO vDAO = new VendaDAO();
                    int idPedido = vDAO.Insert(venda);

                    ItensVendaDAO itemDAO = new ItensVendaDAO();

                    var carrinho = ObtemCarrinhoNaSession();
                    foreach (var elemento in carrinho)
                    {
                        ItensVendaViewModel item = new ItensVendaViewModel();
                        item.Id_Venda = idPedido;
                        item.Id_Produto = elemento.Id_Produto;
                        item.Quantidade = elemento.Quantidade;
                        item.Preco = elemento.Preco;

                        itemDAO.Insert(item);
                        //carrinho.Remove(elemento);
                    }
                    transacao.Complete();

                }
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                @ViewBag.Erro = "Ocorreu um erro: " + erro.Message;
                return RedirectToAction("Visualizar", "Carrinho");
            }


        }


        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!HelperControllers.VerificaUserLogado(HttpContext.Session))
                context.Result = RedirectToAction("Index", "Login");
            else
            {
                ViewBag.Logado = true;
                base.OnActionExecuting(context);
            }
        }
    }
}