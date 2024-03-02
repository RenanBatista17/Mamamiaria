using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Ecommerce.Application.Dtos;
using Ecommerce.Application.Services.Interfaces;
using Ecommerce.Domain.Identity;
using Ecommerce.Domain.Models;
using Ecommerce.Infrastructure.Repositories.Interfaces;

namespace Ecommerce.Application.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IGeralPersist _geralPersist;
        private readonly IMapper _mapper;
        private readonly IEnderecoPersist _enderecoPersist;

        public EnderecoService(IGeralPersist geralPersist, IMapper mapper, IEnderecoPersist enderecoPersist){
            _geralPersist = geralPersist;
            _mapper = mapper;
            _enderecoPersist = enderecoPersist;
        }

        public async Task<EnderecoDto> AddEndereco(EnderecoDto enderecoDto, int userId)
        {
            try
            {
                var endereco = _mapper.Map<Endereco>(enderecoDto);
                endereco.UsuarioId = userId;
                _geralPersist.Add(endereco);

                if(await _geralPersist.SaveChangesAsync()){
                    var enderecoParaRetorno = await _enderecoPersist.GetEnderecoByUserId(userId);
                    return _mapper.Map<EnderecoDto>(enderecoParaRetorno);
                }

                return null;
            }
            catch (Exception e)
            {
                
                throw;
            };
        }

        public async Task<EnderecoDto> GetEnderecoByIdUser(int userId)
        {
            try
            {
                var endereco = await _enderecoPersist.GetEnderecoByUserId(userId);
                return _mapper.Map<EnderecoDto>(endereco);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public async Task<EnderecoDto> UpdateEndereco(int userId, EnderecoDto enderecoDto)
        {
            try
            {
                var enderecoDoBanco = await _enderecoPersist.GetEnderecoByUserId(userId);
                enderecoDto.Id = enderecoDoBanco.Id;

                _mapper.Map(enderecoDto, enderecoDoBanco);
                _geralPersist.Update(enderecoDoBanco);

                if(await _geralPersist.SaveChangesAsync()){
                    return _mapper.Map<EnderecoDto>(enderecoDoBanco);
                }

                return null; 
            }
            catch (System.Exception)
            {
                
                throw;
            }            
        }
    }
}