using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Application.Dtos;
using Ecommerce.Domain.Models;

namespace Ecommerce.Application.Services.Interfaces
{
    public interface IPizzaService
    {
        List<PizzaDto> GetAllPizzas();
        List<PizzaDto> GetAllPizzasEspeciais();
    }
}