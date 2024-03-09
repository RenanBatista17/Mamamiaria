using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using AutoMapper;
using Ecommerce.Application.Dtos;
using Ecommerce.Application.Services.Interfaces;
using Ecommerce.Domain.Models;
using Ecommerce.Infrastructure.Repositories.Interfaces;

namespace Ecommerce.Application.Services
{
    public class PizzaService : IPizzaService
    {
        private readonly IPizzaPersist _pizzaPersist;
        private readonly IMapper _mapper;

        public PizzaService(IPizzaPersist pizzaPersist, IMapper mapper){
            _pizzaPersist = pizzaPersist;
            _mapper = mapper;
        }
        public List<PizzaDto> GetAllPizzas()
        {
            try
            {
                var pizzas = _pizzaPersist.GetAllPizzas();
                var pizzasParaRetorno = _mapper.Map<List<PizzaDto>>(pizzas);
                return pizzasParaRetorno;
            }
            catch (Exception e)
            {
                
                throw new Exception($"Erro: {e.Message}");
            }
        }

        public List<PizzaDto> GetAllPizzasEspeciais()
        {
            try
            {
                var pizzasEspeciais = _pizzaPersist.GetAllPizzasEspeciais();
                var pizzasEspeciaisParaRetorno = _mapper.Map<List<PizzaDto>>(pizzasEspeciais);
                return pizzasEspeciaisParaRetorno;
            }
            catch (Exception e)
            {
                
                throw new Exception($"Erro: {e.Message}");
            }
        }
    }
}