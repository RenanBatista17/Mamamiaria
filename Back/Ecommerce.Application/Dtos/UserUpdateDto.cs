using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Application.Dtos
{
    public class UserUpdateDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O {0} é requerido.")]
        [StringLength(25, MinimumLength =3,
                        ErrorMessage = "Intervalo permitido para o {0} é de 3 a 25 caractéres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O {0} é requerido.")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "A {0} é requerida.")]
        public string Cidade { get; set; }

        [EmailAddress(ErrorMessage = "Insira um {0} válido.")]
        [Required(ErrorMessage = "{0} é requerido.")]
        public string Email { get; set; }

        [Editable(false)]
        public int Cpf { get; set; }

        [Required(ErrorMessage = "A {0} é requerida.")]
        public string PassWord { get; set; }
    }
}