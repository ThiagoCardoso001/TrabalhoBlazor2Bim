using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CadastroProdutoApi.Models;
using CadastroProdutoApi.DAOs;
using CadastroProdutoApi.Controllers.Extensoes;
using CadastroProdutoDll.DOs;

namespace CadastroProdutoRecordApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoRecordController : ControllerBase
    {
        // GET: api/ProdutoRecord
        [HttpGet]
        public async Task<ActionResult<IList<ProdutoRecordDO>>> Get()
        {
            return Ok((await dao.RetornarTodosAsync()).ToDO());
        }

        // GET: api/ProdutoRecord
        [HttpGet("mestre/{idMestre}")]
        public async Task<ActionResult<IList<ProdutoRecordDO>>> GetPorIdMestre(string idMestre)
        {
            return Ok((await dao.RetornarPorIdMestreAsync(idMestre)).ToDO());
        }

        // GET: api/ProdutoRecord/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoRecordDO>> GetPorId(string id)
        {
            var objeto = await dao.RetornarPorIdAsync(id);

            if (objeto == null)
                return NotFound();
            
            return Ok(objeto.ToDO());
        }

        // POST: api/ProdutoRecord
        [HttpPost]
        public async Task<ActionResult<ProdutoRecordDO>> Post(ProdutoRecordDO objDO)
        {
            if (objDO == null)
                return Problem("O record que você está tentando inserir está nulo.");

            var objeto = await objDO.ToModel();

            await dao.InserirAsync(objeto);

            objDO = objeto.ToDO();

            return CreatedAtAction(nameof(GetPorId), new { id = objDO.Id }, objDO);
        }

        // PUT: api/ProdutoRecord/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, ProdutoRecordDO novoProdutoRecordDO)
        {
            if (id != novoProdutoRecordDO.Id)
                return Problem("Como você pode me enviar um id na rota diferente do id do objeto?");
                //return BadRequest();
            
            try
            {
                await dao.AlterarAsync(await novoProdutoRecordDO.ToModel());
            }
            catch (Exception)
            {
                throw;
            }

            return NoContent();
        }

        // DELETE: api/ProdutoRecord/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await dao.ExcluirAsync(id);
            
            return NoContent();
        }

        private ProdutoRecordDAO dao = new ProdutoRecordDAO();
    }
}