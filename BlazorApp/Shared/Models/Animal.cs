using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BlazorApp.Shared.Models
{
    public class Animal
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "O nome da Fazenda é obrigatório", AllowEmptyStrings = false)]
        [ForeignKey("FazendaId")]
        public int? FazendaID { get; set; }

        [Required(ErrorMessage = "O campo TAG é obrigatório", AllowEmptyStrings = false)]
        [StringLength(15, MinimumLength = 15, ErrorMessage = "A TAG deve conter 15 caracteres")]
        [Display(Name = "Tag")]
        public string? Tag { get; set; } 
    }
}