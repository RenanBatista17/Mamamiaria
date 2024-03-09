using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Ecommerce.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class PizzaController : ControllerBase
    {
        private readonly IPizzaService _pizzaService;

        public PizzaController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        [HttpGet("GetAllPizzas")]
        [AllowAnonymous]
        public IActionResult GetAllPizzas(){
            try
            {
                return Ok(_pizzaService.GetAllPizzas());
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        [HttpGet("GetAllPizzasEspeciais")]
        [AllowAnonymous]
        public IActionResult GetAllPizzasEspeciais(){
            try
            {
                return Ok(_pizzaService.GetAllPizzasEspeciais());
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }
    }
}