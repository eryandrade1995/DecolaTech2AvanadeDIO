using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmploPoo.Models
{
    public class Retangulo
    {
        private double comprimento;
        private double largura;
        private bool valido;

        public void DefinirMedidas(double comprimento, double largura)
        {   
            if(comprimento > 0 && largura > 0)
            {
                this.comprimento = comprimento;
                this.largura = largura;
                valido = true;
            }
            else
            {
                Console.WriteLine("Valores inválidos!");
            }
        }

        public double ObterArea()
        {
            if (valido)
            {
                return comprimento * largura;

            }
            else
            {
                Console.WriteLine("Preencha com valores válidos");
                return 0;
            }
        }
    }
}
