using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Domain.Models;

namespace Ecommerce.Infrastructure.Repositories.Interfaces
{
    public interface IPizzaPersist
    {
        List<Pizza> GetAllPizzas();
        List<Pizza> GetAllPizzasEspeciais();
        Pizza GetPizzaById();
    }
}