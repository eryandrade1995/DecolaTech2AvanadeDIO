using PeojetoDIOSeries.Enum;
using ProjetoDIOGames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeojetoDIOGames

        //Atributos
{
    public class Game : EntityBase
    {
        private Gender Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private string EnterpriseDev { get; set; }
        private bool Excluido { get; set; }

        //Métodos

        public Game(int id, Gender genero, string  titulo, string descricao, int ano, string enterpriseDev)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.EnterpriseDev = enterpriseDev;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Empresa Desenvolvedora: " + this.EnterpriseDev + Environment.NewLine;
            retorno += "Ano de Lançamento: " + this.Ano + Environment.NewLine; 
            retorno += "Excluído: " + this.Excluido;
            return retorno;
        }

        public string retornTitle()
        {
            return this.Titulo;
        }

        public int retornId()
        {
            return this.Id;
        }

        public bool returnDeleted()
        {
            return this.Excluido;
        }

        public void Delet()
        {
            this.Excluido = true;
        }
    }
}
