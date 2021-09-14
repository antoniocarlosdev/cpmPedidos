using Microsoft.AspNetCore.Mvc;
using System;

namespace CpmPedidos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : AppBaseController
    {

        public PedidoController(IServiceProvider serviceProvider) : base(serviceProvider)
        {
         
        }
    }
}
