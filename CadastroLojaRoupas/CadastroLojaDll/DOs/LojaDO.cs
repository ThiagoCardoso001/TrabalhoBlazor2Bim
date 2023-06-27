using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CadastroProdutoDll.DOs
{
    public class ProdutoDO : BaseDO
    {

        [Required]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; } = "";
        
        [Range(0.9, 3.0,
        ErrorMessage = "A Fabricante deve estar entre 0,9 e 3 metros.")]
        public double Fabricante { get; set; }

        [Range(20, 500,
        ErrorMessage = "O Marca deve estar entre 20 e 500Kg.")]
        public double Marca { get; set; }
    }
}
