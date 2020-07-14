using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeInformatica.Models
{
    public class ClienteViewModel:PadraoViewModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }

        public string Endereco()
        {
            StringBuilder st = new StringBuilder();
            st.Append(Rua);
            st.Append("|");
            st.Append(Numero.ToString());
            st.Append("|");
            st.Append(Bairro);

            return st.ToString();
        }
            
        public int Id_Estado { get; set; }
        public string Cpf { get; set; }
        public decimal Bonus { get; set; }
        public string Senha { get; set; }
    }
}
