using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmploPoo.Models
{
    public class Gandula : Goleiro
    {
        public override void Apresentar()
        {
            Console.WriteLine($"{Nome}, {Idade} anos,  defesa é considerada no valor de {Defesa}.");
        }
    }
}
