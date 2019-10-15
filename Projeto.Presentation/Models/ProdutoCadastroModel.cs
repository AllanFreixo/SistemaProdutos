using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Presentation.Models
{
    public class ProdutoCadastroModel
    {

        [Required(ErrorMessage ="Por Favor informe o nome do Produto")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="Por Favor informe o valor do Produto")]
        public decimal Preco { get; set; }
        [Required(ErrorMessage ="Por Favor informe a quantidade do Produto")]
        public int Quantidade { get; set; }


    }
}
