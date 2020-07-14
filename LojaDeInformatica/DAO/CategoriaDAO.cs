using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using LojaDeInformatica.Models;

namespace LojaDeInformatica.DAO
{
    public class CategoriaDAO : PadraoDAO<CategoriaViewModel>
    {
        protected override SqlParameter[] CriaParametros(CategoriaViewModel model)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("id",model.Id),
                new SqlParameter("descricao",model.Descricao)
            };

            return parametros;
        }

        protected override CategoriaViewModel MontaModel(DataRow registro)
        {
            CategoriaViewModel cat = new CategoriaViewModel()
            {
                Id=Convert.ToInt32(registro["id"]),
                Descricao=registro["descricao"].ToString()
            };

            return cat;
        }

        protected override void SetTabela()
        {
            Tabela = "Categoria";
        }
    }
}
