using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Presentation.Models
{
    public class ProdutoEdicaoModel
    {   
        [Required(ErrorMessage = "Por Favor informe a Id do Produto")]
        public int IdProduto { get; set; }
        [Required(ErrorMessage ="Informe o Nome do Produto")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="Informe o Preço do Produto")]
        public decimal Preco { get; set; }
        [Required(ErrorMessage ="Informe a Quantidade do Produto")]
        public int Quantidade { get; set; }
    }
}
