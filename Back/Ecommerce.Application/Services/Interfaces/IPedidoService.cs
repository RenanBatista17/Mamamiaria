using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Application.Dtos;

namespace Ecommerce.Application.Services.Interfaces
{
    public interface IPedidoService
    {
        void CriarPedido(PedidoDto pedido, int userId);
    }
}