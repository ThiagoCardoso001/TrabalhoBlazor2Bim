using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroProdutoApi.Models
{
    public class Produto : BaseModel
    {
        public string Nome { get; set; } = "";

        public double Altura { get; set; }

        public double Peso { get; set; }
    }
}