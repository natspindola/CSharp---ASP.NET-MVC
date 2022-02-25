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
        public string Nome { get; set; }

        [DisplayName("Idade da pessoa:")]
        public  int idade { get; set; }

        [Required(ErrorMessage = "O endereço é obrigatório ")]
        [DisplayName("Endereço da pessoa:")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "O email é obrigatório ")]
        [DisplayName("Email da pessoa:")]
        public string Email { get; set; }
    }
}