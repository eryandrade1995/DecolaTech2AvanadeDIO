using PeojetoDIOGames;
using PeojetoDIOSeries.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeojetoDIOSeries
{
    public class GameRepository : IRepository<Game>
    {
        //Implementada na interface IRepository
        private List<Game> listGame = new List<Game>();
        public void Delete(int id)
        {
            listGame[id].Delet();
        }

        public void Insert(Game objeto)
        {
            listGame.Add(objeto);
        }

        public List<Game> Listt()
        {
            return listGame;
        }

        public int NextId()
        {
            return listGame.Count;
        }

        public Game RetornId(int id)
        {
            return listGame[id];
        }

        public void Update(int id, Game objeto)
        {
            listGame[id] = objeto;
        }
    }
}
