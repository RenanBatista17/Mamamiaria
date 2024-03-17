using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.API.Extensions;
using Ecommerce.Application.Dtos;
using Ecommerce.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Ecommerce.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoController : Controller
    {
        private readonly IPedidoService _pedidoService;

        public PedidoController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpPost("CriarPedido")]
        public IActionResult CriarPedido([FromBody] PedidoDto pedidoDto){
            try
            {
                _pedidoService.CriarPedido(pedidoDto, User.GetId());
                return Ok();
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

       
    }
}