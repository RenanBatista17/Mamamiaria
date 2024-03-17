using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Domain.Identity;

namespace Ecommerce.Domain.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public User Usuario { get; set; }
        public int UsuarioId { get; set; }
        public string Telefone { get; set; }
        public string ModoDePagamento { get; set; }
        public string ModoDeEntrega { get; set; }
        public int PizzaId { get; set; }
        public Pizza Pizza { get; set; }

    }
}