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
    public class EnderecoPersist : IEnderecoPersist
    {
        private readonly DataContext _dataContext;

        public EnderecoPersist(DataContext dataContext){
            _dataContext = dataContext;
        }
        public async Task<Endereco> GetEnderecoByUserId(int userId)
        {
            var endereco = await _dataContext.Enderecos.FirstOrDefaultAsync(e => e.UsuarioId == userId);

            return endereco;
        }
    }
}