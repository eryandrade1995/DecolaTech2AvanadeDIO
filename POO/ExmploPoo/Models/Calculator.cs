using ExmploPoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmploPoo.Models
{
    public class Calculator : ICalculadora
    {
        public int Dividir(int a, int b)
        {
            return a / 2;
        }

        public int Somar(int a, int b)
        {
            return a + b;
        }
        public int Somar(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }
    }
}
