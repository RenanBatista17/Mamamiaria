using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Ecommerce.Application.Dtos;
using Ecommerce.Application.Services.Interfaces;
using Ecommerce.Domain.Models;
using Ecommerce.Infrastructure.Repositories.Interfaces;

namespace Ecommerce.Application.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IGeralPersist _geralPersist;
        private readonly ICarrinhoPersist _carrinhoPersist;
        private  readonly IMapper _mapper;


        public PedidoService(IGeralPersist geralPersist, ICarrinhoPersist carrinhoPersist, IMapper mapper){
            _geralPersist = geralPersist;
            _carrinhoPersist = carrinhoPersist;
            _mapper = mapper;

        }
        public void CriarPedido(PedidoDto pedidoDto, int userId)
        {
            
            try
            {
                pedidoDto.UsuarioId = userId;
                var carrinhoitens = _carrinhoPersist.GetCarrinhoByUserId(userId).Itens;
                pedidoDto.PizzaId = carrinhoitens.First().PizzaId;
                
                var pedido = _mapper.Map<Pedido>(pedidoDto);

                _geralPersist.Add(pedido);
                _geralPersist.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}