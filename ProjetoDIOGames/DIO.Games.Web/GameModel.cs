using DIOGames;
using DIOGames.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO.Games.Web
{
    public class GameModel
    {
        public int Id { get; set; }

        public Gender Genero { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
        public string EnterpriseDev { get; set; }
        public bool Excluido { get; set; }


        public GameModel() { }
        public GameModel(Game game)
        {
            Id = game.retornId();
            Genero = game.returnGenero();
            Titulo = game.retornTitle();
            Descricao = game.returnDescription();
            Excluido = game.returnDeleted();
            Ano = game.retornYear();
            EnterpriseDev = game.returnEnterprise();
        }

        public Game ToGame()
        {
            return new Game(Id, Genero, Titulo, Descricao, Ano, EnterpriseDev);
        }
    }

}
