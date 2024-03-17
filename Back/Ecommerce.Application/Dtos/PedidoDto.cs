using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Application.Dtos
{
    public class PedidoDto
    {
        public string Nome { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Telefone { get; set; }
        public string ModoDePagamento { get; set; }
        public string ModoDeEntrega { get; set; }
        public int UsuarioId { get; set; }
        public int PizzaId { get; set; }
    }
}