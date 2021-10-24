using Microsoft.AspNetCore.Mvc;
using System;

namespace VouViajar.Modulos.Catalogo.Application.Controllers
{

    [Route("api/catalogo")]
    [ApiController]
    public class CatalogoController
    {
        public CatalogoController()
        {
        }

        [HttpPost]
        public ActionResult CadastrarItemCatalago()
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public ActionResult AtualizarItemCatalago()
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public ActionResult ExcluirItemCatalago()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public ActionResult ObterItemCatalago()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public ActionResult ObterTodosItensCatalago()
        {
            throw new NotImplementedException();
        }
    }
}
