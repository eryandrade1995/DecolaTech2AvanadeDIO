using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        //private readonly string nome = "Ery"; //readonly como o próprio nome já diz, não permite alterações de seu valor, sendo apenas para ser instanciado como leitura
        //private readonly string sobrenome;
        private string nome;
        private string sobrenome;

        //public Pessoa()
        //{
        //    nome = string.Empty;
        //    sobrenome = string.Empty;
        //}

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            //Console.WriteLine("Construtor classe Pessoa");
        }

        public void Apresentar()
        {
            Console.WriteLine($"Hello my name is: {nome} {sobrenome}");
        }
    }
}
