using LojaDeInformatica.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace LojaDeInformatica.DAO
{
    public class ItensVendaDAO : PadraoDAO<ItensVendaViewModel>
    {
        protected override SqlParameter[] CriaParametros(ItensVendaViewModel model)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("id",model.Id),
                new SqlParameter("id_venda",model.Id_Venda),
                new SqlParameter("id_produto",model.Id_Produto),
                new SqlParameter("quantidade",model.Quantidade),
                new SqlParameter("preco",model.Preco)
            };

            return parametros;
        }

        protected override ItensVendaViewModel MontaModel(DataRow registro)
        {
            ItensVendaViewModel iv = new ItensVendaViewModel()
            {
                Id=Convert.ToInt32(registro["id"]),
                Id_Venda = Convert.ToInt32(registro["id_venda"]),
                Id_Produto =Convert.ToInt32(registro["id_produto"]),
                Quantidade=Convert.ToInt32(registro["quantidade"]),
                Preco=Convert.ToDecimal(registro["preco"])
            };
            return iv;
        }

        protected override void SetTabela()
        {
            Tabela="ItensVenda";
            ChaveIdentity = true;
        }
    }
}
