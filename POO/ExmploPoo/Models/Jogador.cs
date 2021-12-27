using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmploPoo.Models
{
    public class Jogador : Pessoa
    {
        public int Finalizacao { get; set; }

        public override void Apresentar() //método sobrescrito "override"
        {
            Console.WriteLine($"{Nome}, {Idade} anos, finalização é considerada no valor de {Finalizacao}.");
        }
    }
}
