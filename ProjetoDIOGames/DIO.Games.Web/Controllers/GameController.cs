using DIOGames;
using DIOGames.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO.Games.Web.Controllers
{
    [Route("[controller]")]
    public class GameController : Controller
    {

        private readonly IRepository<Game> _repositorioGame;

        public GameController(IRepository<Game> repositoryGame)
        {
            _repositorioGame = repositoryGame;
        }

        [HttpGet("")]

        public IActionResult Lista()
        {
            return Ok(_repositorioGame.Listt().Select(g => new GameModel(g)));
        }

        [HttpPut("{id}")]
        public IActionResult Atualiza(int id, [FromBody] GameModel model)
        {
            _repositorioGame.Update(id, model.ToGame());
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Exclui(int id)
        {
            _repositorioGame.Delete(id);
            return NoContent();
        }

        [HttpPost("")]
        public IActionResult Insere([FromBody] GameModel model)
        {
            model.Id = _repositorioGame.NextId();
            Game game = model.ToGame();


            _repositorioGame.Insert(game);
            return Created("", game);
        }

        [HttpGet("{id}")]
        public IActionResult Consulta(int id)
        {
            return Ok(new GameModel(_repositorioGame.Listt().FirstOrDefault(g => g.Id == id)));
        }
    }
}
