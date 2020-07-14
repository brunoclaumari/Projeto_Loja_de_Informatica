using LojaDeInformatica.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace LojaDeInformatica.DAO
{
    public class ProdutoDAO : PadraoDAO<ProdutoViewModel>
    {
        protected override SqlParameter[] CriaParametros(ProdutoViewModel model)
        {
            object imgByte =model.ImagemEmByte;
            if (imgByte == null)
                imgByte = DBNull.Value;

            SqlParameter[] parametros =
            {
                new SqlParameter("id",model.Id),
                new SqlParameter("imagem",imgByte),
                new SqlParameter("descricao",model.Descricao),
                new SqlParameter("id_categoria",model.Id_Categoria),
                new SqlParameter("preco",model.Preco),
                new SqlParameter("id_marca",model.Id_Marca),
                new SqlParameter("qtd_estoque",model.Qtd_Estoque)
                //new SqlParameter("qtd_reservado",model.Qtd_Reservado)
            };

            return parametros;
        }

        protected override ProdutoViewModel MontaModel(DataRow registro)
        {
            CategoriaViewModel cat = new CategoriaViewModel();
            CategoriaDAO cDao = new CategoriaDAO();
            
            MarcaViewModel marca = new MarcaViewModel();
            MarcaDAO mDao = new MarcaDAO ();
            

            ProdutoViewModel p = new ProdutoViewModel()
            {
                Id = Convert.ToInt32(registro["id"]),
                Descricao = registro["descricao"].ToString(),
                Id_Categoria = Convert.ToInt32(registro["id_categoria"]),                
                Preco=Convert.ToDecimal(registro["Preco"]),
                Id_Marca=Convert.ToInt32(registro["id_marca"]),
                Qtd_Estoque= Convert.ToInt32(registro["qtd_estoque"])
                //Qtd_Reservado= Convert.ToInt32(registro["qtd_reservado"])
            };
            cat = cDao.Consulta(p.Id_Categoria);
            marca = mDao.Consulta(p.Id_Marca);

            p.Desc_Categoria = cat.Descricao;
            p.Desc_Marca = marca.Marca;


            if (registro["imagem"] != DBNull.Value)
            {
                p.ImagemEmByte = registro["imagem"] as byte[];
            }
            

            return p;
        }

        protected override void SetTabela()
        {
            Tabela="Produto";
        }

        public int ExisteImagem(string operacao, byte[] imagem)
        {
            var p = new SqlParameter[]
            {
                new SqlParameter("operacao", operacao),
                new SqlParameter("imagem", imagem)
            };
            var tabela = HelperDAO.ExecutaProcSelect("spConsultaImagem", p);

            return Convert.ToInt32(tabela.Rows[0][0]);
            //se retornar -1 nao deixa inserir ou alterar
            //se retornar 1 deixa
        }

        //Aqui estou na tentativa de fazer a consulta 
        public List<ProdutoViewModel> FiltroProdutos(int id_categoria,
                        int id_marca, decimal preco)
        {
            var p = new SqlParameter[]
             {
                new SqlParameter("idCategoria", id_categoria),
                new SqlParameter("idMarca", id_marca) ,
                new SqlParameter("preco", preco)

             };
            var tabela = HelperDAO.ExecutaProcSelect("sp_FiltroProduto", p);
            List<ProdutoViewModel> lista = new List<ProdutoViewModel>();
            foreach (DataRow registro in tabela.Rows)
            {
                lista.Add(MontaModel(registro));
            }
            return lista;
        }
    }
}
