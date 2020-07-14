using LojaDeInformatica.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace LojaDeInformatica.DAO
{
    public class EstadoDAO : PadraoDAO<EstadoViewModel>
    {
        protected override SqlParameter[] CriaParametros(EstadoViewModel model)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("id",model.Id),
                new SqlParameter("estado",model.Estado),
                new SqlParameter("descricao",model.Descricao),
                new SqlParameter("id_regiao",model.Id_Regiao)
            };

            return parametros;
        }

        protected override EstadoViewModel MontaModel(DataRow registro)
        {
            EstadoViewModel estado = new EstadoViewModel
            {
                Id = Convert.ToInt32(registro["id"]),
                Estado = registro["estado"].ToString(),
                Descricao = registro["descricao"].ToString(),
                Id_Regiao=Convert.ToInt32(registro["id_regiao"])
            };

            return estado;
        }

        protected override void SetTabela()
        {
            Tabela="Estado";
        }
    }
}
