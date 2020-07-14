using LojaDeInformatica.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace LojaDeInformatica.DAO
{
    public class RegiaoDAO : PadraoDAO<RegiaoViewModel>
    {
        protected override SqlParameter[] CriaParametros(RegiaoViewModel model)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("id",model.Id),
                new SqlParameter("sigla",model.Sigla),               
                new SqlParameter("descricao",model.Descricao)
            };

            return parametros;
        }

        protected override RegiaoViewModel MontaModel(DataRow registro)
        {
            RegiaoViewModel reg = new RegiaoViewModel()
            {
                Id = Convert.ToInt32(registro["id"]),
                Sigla = registro["sigla"].ToString(),
                Descricao = registro["descricao"].ToString()
            };

            return reg;
        }

        protected override void SetTabela()
        {
            Tabela = "Regiao";
        }
    }
}
