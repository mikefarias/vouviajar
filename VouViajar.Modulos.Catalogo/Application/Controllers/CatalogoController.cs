﻿using Microsoft.AspNetCore.Mvc;
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
        public ActionResult CadastrarItemCatalogo()
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public ActionResult AtualizarItemCatalogo()
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public ActionResult ExcluirItemCatalogo()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public ActionResult ObterItemCatalogo()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public ActionResult ObterTodosItensCatalogo()
        {
            throw new NotImplementedException();
        }
    }
}
