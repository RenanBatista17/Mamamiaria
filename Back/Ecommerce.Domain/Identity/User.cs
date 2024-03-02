using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Domain.Models;
using Microsoft.AspNetCore.Identity;

namespace Ecommerce.Domain.Identity
{
    public class User : IdentityUser<int>
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Cpf { get; set; }
        public List<UserRole> UserRoles { get; set; }
    }
}