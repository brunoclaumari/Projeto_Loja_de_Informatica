using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeInformatica.DAO
{
    public static class ConexaoBD
    {        
        public static SqlConnection GetConexao()
        {
            string strCon = "Data Source=LOCALHOST;Initial Catalog=LojaInformatica;user id=sa; password=123456";            
            //string strCon = "Data Source=LOCALHOST\\SQL_MGV6;Initial Catalog=AULADB;integrated security=true";
            SqlConnection conexao = new SqlConnection(strCon);
            conexao.Open();
            return conexao;
        }
    }
}
