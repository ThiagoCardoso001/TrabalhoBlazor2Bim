using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroProdutoApi.Models;

namespace CadastroProdutoApi.DAOs
{
    public class ProdutoDAO : AutoDAO<Produto>
    {
        protected override string Tabela => "Produto";
    }
}