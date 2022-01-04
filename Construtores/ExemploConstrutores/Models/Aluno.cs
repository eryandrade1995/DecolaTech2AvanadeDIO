using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    class Aluno : Pessoa
    {
        public Aluno(string nome, string sobrenome, string disciplina) : base (nome, sobrenome) //atribuir atributos a classe mãe
        {
            Console.WriteLine("Construtor classe Aluno");
        }
    }
}
