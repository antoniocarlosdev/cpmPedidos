using CpmPedidos.Interfaces;
using CpmPedidosDomain.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CpmPedidos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : AppBaseController
    {

        public ProdutoController(IServiceProvider serviceProvider) : base(serviceProvider)
        {

        }

        [HttpGet]
        public dynamic Get()
        {
            var rep = (IProdutoRepository)ServiceProvider.GetService(typeof(IProdutoRepository));
            return rep.Get();
        }

        [HttpGet]
        [Route("search/{text}/{pagina?}")]
        public dynamic GetSearch(string text, int pagina = 1)
        {
            var rep = (IProdutoRepository)ServiceProvider.GetService(typeof(IProdutoRepository));
            return rep.Search(text, pagina);
        }

        [HttpGet]
        [Route("{id}")]
        public dynamic Detail(int? id)
        {
            if ((id ?? 0) > 0)
            {
                var rep = (IProdutoRepository)ServiceProvider.GetService(typeof(IProdutoRepository));
                return rep.Detail(id.Value);
            }
            else
            {
                return null;
            }
        }

        [HttpGet]
        [Route("{id}/imagens")]
        public dynamic Imagens(int? id)
        {
            if ((id ?? 0) > 0)
            {
                var rep = (IProdutoRepository)ServiceProvider.GetService(typeof(IProdutoRepository));
                return rep.Imagens(id.Value);
            }
            else
            {
                return null;
            }
        }

    }

}
