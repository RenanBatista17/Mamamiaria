using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Domain.Identity;

namespace Ecommerce.Domain.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Cep { get; set; }
        public User Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}