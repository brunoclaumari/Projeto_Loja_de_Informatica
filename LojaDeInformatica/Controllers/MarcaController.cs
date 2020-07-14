using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaDeInformatica.DAO;
using LojaDeInformatica.Models;
using Microsoft.AspNetCore.Mvc;

namespace LojaDeInformatica.Controllers
{
    public class MarcaController : PadraoController<MarcaViewModel>
    {
        public MarcaController()
        {
            DAO = new MarcaDAO();
            GeraProximoId = true;
        }        

        protected override void ValidaDados(MarcaViewModel model, string operacao)
        {
            base.ValidaDados(model, operacao);
            MarcaDAO dao = new MarcaDAO();

            if (string.IsNullOrEmpty(model.Marca))
                ModelState.AddModelError("marca", "Preencha a marca!!");
            if (dao.ExisteMarca(model.Id, model.Marca) == -1)
                ModelState.AddModelError("marca", "Essa marca já existe!!");
        }
    }
}