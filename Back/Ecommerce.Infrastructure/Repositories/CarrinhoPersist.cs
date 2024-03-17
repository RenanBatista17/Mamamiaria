using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Domain.Models;
using Ecommerce.Infrastructure.EntityFramework.Contextos;
using Ecommerce.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastructure.Repositories
{
    public class CarrinhoPersist : GeralPersist, ICarrinhoPersist
    {
        public DataContext _dataContext { get; set; }
        public CarrinhoPersist(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public Carrinho GetCarrinhoByUserId(int userId)
        {
            return _dataContext.Carrinhos.Include(ci => ci.Itens).Single(c => c.UserId == userId);
        }
    }
}