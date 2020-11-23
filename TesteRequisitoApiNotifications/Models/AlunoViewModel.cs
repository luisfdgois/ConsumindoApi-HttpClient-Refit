using System;
using System.ComponentModel.DataAnnotations;

namespace TesteRequisitoApiNotifications.Models
{
    public class AlunoViewModel
    {
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Display(Name = "Matrícula")]
        public int matricula { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Nascimento")]
        public DateTime nascimento { get; set; }
    }
}
