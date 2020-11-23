using System;
using System.ComponentModel.DataAnnotations;

namespace TesteRequisitoApiNotifications.Models
{
    public class AlunoCadastro
    {
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Display(Name = "Sobrenome")]
        public string sobrenome { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime nascimento { get; set; }
    }
}
