using ExmploPoo.Helper;
using ExmploPoo.Interfaces;
using ExmploPoo.Models;
using System;

namespace ExmploPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\WorkFiles";

            FileHelper helper = new FileHelper();
            helper.ListarDiretorios(caminho);

            //-------------------Interfaces-------------------//

            //ICalculadora calc = new Calculator();
            //Console.WriteLine(calc.Somar(5, 8));

            //-------------------Objects-------------------//

            //Computador comp = new Computador();
            //Console.WriteLine(comp.ToString());

            //-------------------Abstração-------------------//

            //Corrente cc = new Corrente();
            //cc.Creditar(100);

            //cc.ExibirSaldo();

            //-------------------Polimorfismo-------------------//

            //Calculator calculator = new Calculator();
            //Console.WriteLine("Resultado da primeira soma: " + calculator.Somar(10, 10));
            //Console.WriteLine("Resultado da primeira soma: " + calculator.Somar(10, 10, 10));

            //Jogador p1 = new Jogador();

            //p1.Finalizacao = 99;
            //p1.Nome = "Cristiano Ronaldo";
            //p1.Idade = 36;

            //p1.Apresentar();

            //Goleiro p2 = new Goleiro();

            //p2.Defesa = 94;
            //p2.Nome = "Alisson Becker";
            //p2.Idade = 29;

            //p2.Apresentar();

            //-------------------Herança-------------------//

            //Jogador p1 = new Jogador();

            //p1.Finalizacao = 99;
            //p1.Nome = "Cristiano Ronaldo";
            //p1.Idade = 37;

            //p1.Apresentar();

            //-------------------Encapsulamento-------------------//

            ////Valores válidos
            //Retangulo r = new Retangulo();

            //r.DefinirMedidas(25, 30);

            //Console.WriteLine($"Área: {r.ObterArea()}");

            ////Valores inválidos
            //Retangulo rr = new Retangulo();

            //rr.DefinirMedidas(0, 30);

            //Console.WriteLine($"Área: {rr.ObterArea()}");

            //-------------------Abstração-------------------//

            //Pessoa p1 = new Pessoa();

            //p1.Nome = "Barry Allen";
            //p1.Idade = 26;

            //p1.Apresentar();
        }
    }
}
