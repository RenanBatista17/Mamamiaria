using AutoMapper;
using Ecommerce.Application.Dtos;
using Ecommerce.Domain.Identity;
using Ecommerce.Domain.Models;

namespace Ecommerce.Application.Helpers
{
    public class EcommerceProfile : Profile
    {
        public EcommerceProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserLoginDto>().ReverseMap();
            CreateMap<User, UserUpdateDto>().ReverseMap();
            CreateMap<Endereco, EnderecoDto>().ReverseMap();
            CreateMap<Pizza, PizzaDto>().ReverseMap();
            CreateMap<Pedido, PedidoDto>().ReverseMap();
        }
    }
}