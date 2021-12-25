using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface ICar
    {

        void Tipo(string tipo);

        void VelMax(int velMax);

        void Fabricante(string fabricante);

        void Modelo(string modelo);
    }

    class Carro : ICar
    {

        public string Tipo { get; set; }

        public int VelMax { get; set; }

        public string Fabricante { get; set; }

        public string Modelo { get; set; }

        void ICar.Tipo(string tipo)
        {
            this.Tipo = tipo;
        }
        void ICar.VelMax(int velMax)
        {
            this.VelMax = velMax;
        }
        void ICar.Fabricante(string fabricante)
        {
            this.Fabricante = fabricante;
        }
        void ICar.Modelo(string modelo)
        {
            this.Modelo = modelo;
        }
    }

}
