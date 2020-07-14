using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaDeInformatica.DAO;
using LojaDeInformatica.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LojaDeInformatica.Controllers
{
    public class ClienteController : PadraoController<ClienteViewModel>
    {
        public ClienteController()
        {
            DAO = new ClienteDAO();
            GeraProximoId = true;
        }

        protected override void PreencheDadosParaView(string Operacao, ClienteViewModel model)
        {
            base.PreencheDadosParaView(Operacao, model);
            PreparaEstadoParaCombo();
        }

        private void PreparaEstadoParaCombo()
        {
            EstadoDAO estDAO = new EstadoDAO();
            var estados = estDAO.Listagem();

            List<SelectListItem> listaEstados = new List<SelectListItem>();

            listaEstados.Add(new SelectListItem("Selecione um Estado...", "0"));

            foreach (var estado in estados)
            {
                SelectListItem item = new SelectListItem(estado.Descricao, estado.Id.ToString());
                listaEstados.Add(item);
            }
            ViewBag.Estado = listaEstados;
        }

        protected override void ValidaDados(ClienteViewModel model, string operacao)
        {
            base.ValidaDados(model, operacao);
            ClienteDAO dao = new ClienteDAO();

            if (model.Numero < 0)
                ModelState.AddModelError("numero", "Não pode ser número negativo");
            if (!dao.ValidaCPF(model.Cpf) && operacao == "I")
                ModelState.AddModelError("cpf", "CPF inválido!");
            if (model.Id_Estado <= 0)
                ModelState.AddModelError("id_estado", "Informe o Estado");
            if (dao.ExisteEmail(model.Id, model.Email) == -1)
                ModelState.AddModelError("email", "Esse email já existe!!");
            if (string.IsNullOrEmpty(model.Email))
            {
                ModelState.AddModelError("email", "Campo obrigatório, o email será seu usuário");
            }
            if (model.Senha.Length < 6 || model.Senha.Length > 8)
            {
                ModelState.AddModelError("senha", "Senha deve ser no mínimo 6 e maximo 8 dígitos");
            }



        }


    }
}