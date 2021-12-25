using Interface;
using System;
using EnumEx;
namespace AtvOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var signo1 = (Signos)0;
            var signo2 = Signos.Aries;
            var signo3 = (Signos)4;

            Pessoa vPessoa = new Pessoa();

            vPessoa.Nome = "Gabriel Zancanelli";
            vPessoa.Idade = 24;
            vPessoa.Altura = 183;
            vPessoa.Peso = 100.8;
            vPessoa.Empresa = "Probiótica";

            var vPessoa2 = new Pessoa();

            vPessoa2.Nome = "Ramon Queiroz";
            vPessoa2.Idade = 26;
            vPessoa2.Altura = 180;
            vPessoa2.Peso = 113.1;
            vPessoa2.Empresa = "Max Titanium";

            Carro carro = new Carro();

            carro.Tipo = "Sedan";
            carro.Fabricante = "Jaguar Cars";
            carro.VelMax = 250;
            carro.Modelo = "F-Type";
        }
    }
}
