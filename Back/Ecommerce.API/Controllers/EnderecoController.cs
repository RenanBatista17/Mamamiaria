using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.API.Extensions;
using Ecommerce.Application.Dtos;
using Ecommerce.Application.Services;
using Ecommerce.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Ecommerce.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoService _enderecoService;
        private readonly IUserService _userService;
        public EnderecoController(IEnderecoService enderecoService, IUserService userService)
        {
            _enderecoService = enderecoService;
            _userService = userService;
        }
        
        [HttpPost]
        public async Task<IActionResult> AdicionarEndereco([FromBody] EnderecoDto enderecoDto){
            try
            {                
                var user = await _userService.GetUserByEmailAsync(User.GetEmail());

                var endereco = await _enderecoService.AddEndereco(enderecoDto, user.Id);

                if(endereco != null){
                    return Ok(endereco);
                }

                return NoContent();
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        [HttpPut]
        public async Task<IActionResult> AtualizarEndereco(EnderecoDto enderecoDto){
            try
            {
                var endereco = await _enderecoService.UpdateEndereco(User.GetId(), enderecoDto);
                if(endereco == null) return NoContent();

                return Ok(endereco);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, 
                    $"Erro: {ex.Message}");
            }
        }

        [HttpGet()]
        public async Task<IActionResult> GetEnderecoByUserId(){
            try
            {
                var endereco = await _enderecoService.GetEnderecoByIdUser(User.GetId());
                if(endereco == null) return NoContent();

                return Ok(endereco);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, 
                    $"Erro: {ex.Message}");
            }
        }
    }
}