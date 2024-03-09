using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Domain.Enum;
using Ecommerce.Domain.Models;
using Ecommerce.Infrastructure.EntityFramework.Contextos;
using Ecommerce.Infrastructure.Repositories.Interfaces;

namespace Ecommerce.Infrastructure.Repositories
{
    public class PizzaPersist : IPizzaPersist
    {
        private readonly DataContext _dataContext;
        public PizzaPersist(DataContext dataContext){
            _dataContext = dataContext;
        }
        public List<Pizza> GetAllPizzas()
        {
            var query = _dataContext.Pizzas;
            return query.ToList();
        }

        public List<Pizza> GetAllPizzasEspeciais()
        {
            var query = _dataContext.Pizzas.Where(p => p.Categoria != CategoriaDePizza.Normal);
            return query.ToList();
        }

        public Pizza GetPizzaById(){
            var query = _dataContext.Pizzas.FirstOrDefault();
            return query;
        }
    }
}