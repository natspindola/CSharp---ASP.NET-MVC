using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CSharp___ASP.NET_MVC.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage = "O nome é obrigatório ")]
        [DisplayName("Nome da pessoa:")]
        [MaxLength(50, ErrorMessage = "O nome pode ter no máximo 50 caracteres")]
        [MinLength(3, ErrorMessage = "O nome pode ter no mínimo 3 caracteres ")]
        public string Nome { get; set; }

        [DisplayName("Idade da pessoa:")]
        public  int idade { get; set; }

        [Required(ErrorMessage = "O endereço é obrigatório ")]
        [DisplayName("Endereço da pessoa:")]
        [MaxLength(100, ErrorMessage = "O endereço pode ter no máximo 100 caracteres ")]
        [MinLength(5, ErrorMessage = "O nome pode ter no mínimo 5 caracteres ")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "O email é obrigatório ")]
        [DisplayName("Email da pessoa:")]
        [MaxLength(25, ErrorMessage = "O email pode ter no máximo 25 caracteres ")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public bool Ative { get; set; }
    }
}