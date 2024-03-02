using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Application.Dtos;
using Ecommerce.Domain.Models;

namespace Ecommerce.Application.Services.Interfaces
{
    public interface IEnderecoService
    {
        Task<EnderecoDto> AddEndereco(EnderecoDto enderecoDto, int userId);
        Task<EnderecoDto> UpdateEndereco(int enderecoId, EnderecoDto enderecoDto);
        Task<EnderecoDto> GetEnderecoByIdUser(int userId);
    }
}