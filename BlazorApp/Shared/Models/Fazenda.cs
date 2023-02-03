using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Shared.Models
{
    public class Fazenda
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "O nome da Fazenda é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome da Fazenda")]
        public string Nome { get; set; } = null!;
    }
}