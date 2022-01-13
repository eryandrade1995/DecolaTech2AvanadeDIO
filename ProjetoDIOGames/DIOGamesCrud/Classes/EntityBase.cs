using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIOGames
{
    //Classe abstrata feita para obter um Id nas classes herdadas
    public abstract class EntityBase
    {

        public int Id { get; protected set; }

    }
}
