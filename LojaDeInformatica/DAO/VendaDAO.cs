using LojaDeInformatica.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace LojaDeInformatica.DAO
{
    public class VendaDAO : PadraoDAO<VendaViewModel>
    {
        protected override SqlParameter[] CriaParametros(VendaViewModel model)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("id", model.Id),
                new SqlParameter("data_venda", model.Data_Venda),
                new SqlParameter("id_cliente", model.Id_Cliente),
                new SqlParameter("data_entrega", model.Data_Entrega),
                new SqlParameter("id_estadoEntrega", model.Id_EstadoEntrega)
            };

            return parametros;
        }

        protected override VendaViewModel MontaModel(DataRow registro)
        {
            VendaViewModel v = new VendaViewModel()
            {
                Id = Convert.ToInt32(registro["id"]),
                Data_Venda = Convert.ToDateTime(registro["data_venda"]),
                Id_Cliente = Convert.ToInt32(registro["id_cliente"]),
                Data_Entrega = Convert.ToDateTime(registro["data_entrega"]),
                Id_EstadoEntrega = Convert.ToInt32(registro["id_estadoEntrega"])
            };
            return v;
        }

        protected override void SetTabela()
        {
            Tabela = "Venda";
            ChaveIdentity = true;
        }
    }
}
