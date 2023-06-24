using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroProdutoApi.DAOs;
using CadastroProdutoApi.Models;
using CadastroProdutoDll.DOs;

namespace CadastroProdutoApi.Controllers.Extensoes
{
    public static class EntensoesModelDO
    {
        public static ProdutoDO ToDO(this Produto obj)
        {
            return new ProdutoDO
            {
                Id = obj.Id,
                Nome = obj.Nome,
                Altura = obj.Altura,
                Peso = obj.Peso
            };
        }

        public static IList<ProdutoDO> ToDO(this IList<Produto> listaModels)
        {
            var lista = new List<ProdutoDO>();

            foreach (var obj in listaModels)
                lista.Add(ToDO(obj));

            return lista;
        }
        
        public static async Task<Produto> ToModel(this ProdutoDO objDO)
        {
            Produto? obj = null;

            if (objDO.Id != null)
            {
                var dao = new ProdutoDAO();
                obj = await dao.RetornarPorIdAsync(objDO.Id);
            }

            if (obj == null)
                obj = new Produto();

            obj.Nome = objDO.Nome;
            obj.Altura = objDO.Altura;
            obj.Peso = objDO.Peso;

            return obj;
        }

        public static async Task<IList<Produto>> ToModel(this IList<ProdutoDO> listaDO)
        {
            var lista = new List<Produto>();

            foreach (var obj in listaDO)
                lista.Add(await ToModel(obj));

            return lista;
        }

        public static ProdutoRecordDO ToDO(this ProdutoRecord obj)
        {
            return new ProdutoRecordDO
            {
                Id = obj.Id,
                IdProduto = obj.IdProduto,
                Data = obj.Data,
                Descricao = obj.Descricao
            };
        }

        public static IList<ProdutoRecordDO> ToDO(this IList<ProdutoRecord> listaModels)
        {
            var lista = new List<ProdutoRecordDO>();

            foreach (var obj in listaModels)
                lista.Add(ToDO(obj));

            return lista;
        }

        public static async Task<ProdutoRecord> ToModel(this ProdutoRecordDO objDO)
        {
            ProdutoRecord? obj = null;

            if (objDO.Id != null)
            {
                var dao = new ProdutoRecordDAO();
                obj = await dao.RetornarPorIdAsync(objDO.Id);
            }

            if (obj == null)
                obj = new ProdutoRecord();

            obj.IdProduto = objDO.IdProduto;
            obj.Data = objDO.Data;
            obj.Descricao = objDO.Descricao ?? "";

            return obj;
        }

        public static async Task<IList<ProdutoRecord>> ToModel(this IList<ProdutoRecordDO> listaDO)
        {
            var lista = new List<ProdutoRecord>();

            foreach (var obj in listaDO)
                lista.Add(await ToModel(obj));

            return lista;
        }
    }
}
