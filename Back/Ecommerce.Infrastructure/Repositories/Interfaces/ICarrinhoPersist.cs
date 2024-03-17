using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Domain.Models;

namespace Ecommerce.Infrastructure.Repositories.Interfaces
{
    public interface ICarrinhoPersist : IGeralPersist
    {
        Carrinho GetCarrinhoByUserId(int userId);
    }
}