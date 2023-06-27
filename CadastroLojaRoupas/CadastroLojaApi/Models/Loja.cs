using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroProdutoApi.Models
{
    public class Produto : BaseModel
    {
        public string Nome { get; set; } = "";

        public double Fabricante { get; set; }

        public double Marca { get; set; }
    }
}