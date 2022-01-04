using ExemploConstrutores.Models;
using System;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);

        static void Main(string[] args)
        {
            Matematica mt = new Matematica(5, 1);
            mt.Somar();
            ////Operacao op = Calculadora.Somar;
            //Operacao op = new Operacao(Calculadora.Subtrair);
            //op += Calculadora.Somar; //chama junto ao primeiro delegate outro método em sequência FIFO
            //op.Invoke(25, 5);

            //op(25, 25); //forma de chamar o invoke apenas pela variável do delegate

            //Data data = new Data();
            //data.SetMes(15);

            //data.Mes = 14;//settando um valor para a variável
            //Console.WriteLine(data.Mes);
            //data.ApresentarMes();

            //Aluno p1 = new Aluno("Ery", "Andrade", "Metodologias Ágeis");
            //p1.Apresentar();

            //Log log = Log.GetInstance();

            //log.PropriedadeLog = "Teste instancia";

            //Log log2 = Log.GetInstance();
            //Console.WriteLine(log2.PropriedadeLog);

            //Pessoa p1 = new Pessoa("Ery", "Andrade");
            //p1.Apresentar();

        }
    }
}
