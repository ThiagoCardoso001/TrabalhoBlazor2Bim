using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroProdutoApi.Models;

namespace CadastroProdutoApi.DAOs
{
    public class ProdutoRecordDAO : AutoDAO<ProdutoRecord>
    {
        protected override string Tabela => "Produto_record";

        protected override string? NomeCampoIdMestre => "IdProduto";
    }
}