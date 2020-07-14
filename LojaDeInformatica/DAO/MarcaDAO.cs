using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using LojaDeInformatica.Models;

namespace LojaDeInformatica.DAO
{
    public class MarcaDAO : PadraoDAO<MarcaViewModel>
    {
        protected override SqlParameter[] CriaParametros(MarcaViewModel model)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("id",model.Id),
                new SqlParameter("marca",model.Marca)
            };

            return parametros;
        }

        protected override MarcaViewModel MontaModel(DataRow registro)
        {
            MarcaViewModel marca = new MarcaViewModel()
            {
                Id=Convert.ToInt32(registro["id"]),
                Marca=registro["marca"].ToString()
            };

            return marca;
        }

        protected override void SetTabela()
        {
            Tabela = "Marca";
        }

        public int ExisteMarca(int id, string marca)
        {
            var p = new SqlParameter[]
            {
                new SqlParameter("id", id),
                new SqlParameter("marca", marca)
            };
            var tabela = HelperDAO.ExecutaProcSelect("spExisteMarca", p);

            return Convert.ToInt32(tabela.Rows[0][0]);
            //se retornar -1 nao deixa inserir ou alterar
            //se retornar deixa
        }
    }
}
