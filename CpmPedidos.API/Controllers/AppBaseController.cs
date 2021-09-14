using Microsoft.AspNetCore.Mvc;
using System;

namespace CpmPedidos.API.Controllers
{
    public class AppBaseController : ControllerBase
    {
        protected readonly IServiceProvider ServiceProvider;

        public AppBaseController(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;


        }
    }
}