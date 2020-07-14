using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using LojaDeInformatica.Models;

namespace LojaDeInformatica.DAO
{
    public class ClienteDAO : PadraoDAO<ClienteViewModel>
    {
        //Método que recebe dados da Model envia os parâmetros do Form para o banco 
        protected override SqlParameter[] CriaParametros(ClienteViewModel model)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("id",model.Id),
                new SqlParameter("nome",model.Nome),
                new SqlParameter("email",model.Email),
                new SqlParameter("endereco",model.Endereco()),
                new SqlParameter("id_estado",model.Id_Estado),
                new SqlParameter("CPF",model.Cpf),
                new SqlParameter("bonus",model.Bonus),
                new SqlParameter("senha",model.Senha)
            };

            return parametros;
        }

        //Método que recebe os registros do Banco de Dados e monta a model para mostrar no formulário
        protected override ClienteViewModel MontaModel(DataRow registro)
        {
            string endereco = registro["endereco"].ToString();
            string[] vetor = endereco.Split('|');


            ClienteViewModel cli = new ClienteViewModel()
            {
                Id = Convert.ToInt32(registro["id"]),
                Nome = registro["nome"].ToString(),
                Email = registro["email"].ToString(),
                Rua = vetor[0],
                Numero = Convert.ToInt32(vetor[1]),
                Bairro = vetor[2],
                Id_Estado = Convert.ToInt32(registro["id_estado"]),
                Cpf = registro["CPF"].ToString(),
                Bonus = Convert.ToDecimal(registro["bonus"]),
                Senha = registro["senha"].ToString()

            };

            return cli;
        }

        protected override void SetTabela()
        {
            Tabela = "Cliente";
        }

        public bool ValidaCPF(string cpf)
        {
            var CPF = new SqlParameter[]
            {
                new SqlParameter("cpf",cpf)
            };

            var teste1 = HelperDAO.ExecutaProcSelect("spValidaCpf", CPF);
            int cpfEhValido = Convert.ToInt32(teste1.Rows[0][0]);
            //é um teste que tem que ser 1 para verdadeiro
            CPF = null;
            CPF = new SqlParameter[] { new SqlParameter("cpf", cpf) };
            DataTable teste2 = HelperDAO.ExecutaProcSelect("spConsultaCpf", CPF);
            int cpfJaExiste = Convert.ToInt32(teste2.Rows[0][0]);
            //é um COUNT que tem que ser 0 para ser verdadeiro
            if (cpfEhValido == 1 && cpfJaExiste == 0)
                return true;
            else
                return false;
        }

        public int ExisteEmail(int id, string email)
        {
            var p = new SqlParameter[]
            {
                new SqlParameter("id", id),
                new SqlParameter("email", email)
            };
            var tabela = HelperDAO.ExecutaProcSelect("spConsultaEmail", p);

            return Convert.ToInt32(tabela.Rows[0][0]);
            //se retornar -1 nao deixa inserir ou alterar
            //se retornar deixa

        }

        public int TestaUsuarioSenha(string email, string senha)
        {
            var login = new SqlParameter[]
            {
                new SqlParameter("email2",email),
                new SqlParameter("senha",senha)
            };
            var testeLogin = HelperDAO.ExecutaProcSelect("spTesteLogin", login);
            /*
             -se for igual a -1 usuario não cadastrado
             -se for igual a  0 senha invalida
             -se for igual a  1 vai logar
             */
            return Convert.ToInt32(testeLogin.Rows[0][0]);
        }

        public ClienteViewModel ConsultaClienteLogado(string email)
        {
            var p = new SqlParameter[]
            {
                new SqlParameter("email", email)
                //new SqlParameter("tabela", Tabela)
            };
            var tabela = HelperDAO.ExecutaProcSelect("spConsultaClienteLogado", p);
            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaModel(tabela.Rows[0]);
        }
    }
}
