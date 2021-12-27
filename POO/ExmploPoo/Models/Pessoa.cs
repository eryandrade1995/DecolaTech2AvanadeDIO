using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmploPoo.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Hello, my name is {Nome} and i'm the fastest man alive! Have {Idade} years old.");
        }
    }
}
