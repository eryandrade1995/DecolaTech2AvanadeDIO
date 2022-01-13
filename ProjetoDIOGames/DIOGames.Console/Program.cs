using DIOGames;
using DIOGames.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDIOGames
{
    public class Program
    {

        static GameRepository repository = new GameRepository();

        static void Main(string[] args)
        {

            string option = MenuOption();

            while (option.ToLower() != "6")
            {
                switch (option)
                {
                    case "1":
                        ListGames();
                        break;

                    case "2":
                        InsertGame();
                        break;

                    case "3":
                        UpdateGame();
                        break;

                    case "4":
                        DeleteGame();
                        break;

                    case "5":
                        DisplayGame();
                        break;

                    case "c":
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                option = MenuOption();
            }

            Console.WriteLine("Obrigado pela preferência!");
            Console.WriteLine("Thank you for your custom!");

        }

        private static void DeleteGame()
        {
            bool delOptBool = false;
            var delOption = "";
            Console.WriteLine("Digite o id do game: ");
            int indexGame = int.Parse(Console.ReadLine());

            while (delOptBool == false)
            {
                Console.WriteLine("Deseja mesmo deletar o jogo? Aperte a tecla S para Sim ou N para Não.");
                delOption = Console.ReadLine().ToLower();

                if (delOption == "s")
                {
                    Console.WriteLine("Jogo incluso na lista de excluídos.");
                    repository.Delete(indexGame);
                    delOptBool = true;
                }
                if (delOption == "n")
                {
                    Console.WriteLine("O jogo não foi excluído.");
                    delOptBool = true;
                }
                else
                {

                }
            }   
        }

        private static void DisplayGame()
        {
            Console.WriteLine("Digite o id do jogo: ");
            int indexGame = int.Parse(Console.ReadLine());

            var game = repository.RetornId(indexGame);

            Console.WriteLine(game);
        }

        private static void UpdateGame()
        {

            Console.WriteLine("Digite o id do jogo: ");
            int indexGame = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Gender)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Gender), i));
            }

            Console.WriteLine("Digite o Gênero Desejado: ");
            int getGender = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Título do Jogo: ");
            string getTitle = Console.ReadLine();

            Console.WriteLine("Digite o Ano de Lançamento do Jogo: ");
            int getYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição do Jogo: ");
            string getDescription = Console.ReadLine();

            Console.WriteLine("Digite a Empresa Desenvolvedora do Jogo: ");
            string getEnterprise = Console.ReadLine();

            Game updateGame = new Game(id: indexGame,
                                        genero: (Gender)getGender,
                                        titulo: getTitle,
                                        ano: getYear,
                                        descricao: getDescription,
                                        enterpriseDev: getEnterprise);

            repository.Update(indexGame, updateGame);

        }

        private static void ListGames()
        {
            Console.WriteLine("Listar jogos");

            var list = repository.Listt();

            if (list.Count == 0)
            {
                Console.WriteLine("Nenhum jogo cadastrado.");
                return;
            }

            foreach (var game in list)
            {
                var deleted = game.returnDeleted();

                Console.WriteLine($"#ID {game.retornId()}: - {game.retornTitle()} {(deleted ? "--Jogo Excluído--" : "")}");
            }
        }

        private static void InsertGame()
        {
            Console.WriteLine("Inserir jogo");
            //Varre o Enum Gender, o GetValue retorna todas as opçoes e o GetName mostra cada opção
            foreach (int i in Enum.GetValues(typeof(Gender)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Gender), i));
            }

            Console.WriteLine("Digite o Gênero Desejado: ");
            int getGender = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Título do Jogo: ");
            string getTitle = Console.ReadLine();

            Console.WriteLine("Digite o Ano de Lançamento do Jogo: ");
            int getYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição do Jogo: ");
            string getDescription = Console.ReadLine();

            Console.WriteLine("Digite a Empresa Desenvolvedora do Jogo: ");
            string getEnterprise = Console.ReadLine();

            Game newGame = new Game(id: repository.NextId(),
                                    genero: (Gender)getGender,
                                    titulo: getTitle,
                                    ano: getYear,
                                    descricao: getDescription,
                                    enterpriseDev: getEnterprise);

            repository.Insert(newGame);
        }

        private static string MenuOption()
        {

            Console.WriteLine("\nCatálogo de games\n");
            Console.WriteLine("Selecione a opção no menu:");

            Console.WriteLine("1- Exibir jogos");
            Console.WriteLine("2- Inserir novo jogo");
            Console.WriteLine("3- Atualizar jogo");
            Console.WriteLine("4- Excluir jogo");
            Console.WriteLine("5- Visualizar jogo");
            Console.WriteLine("6- Sair");
            Console.WriteLine("C- Limpar tela\n");

            string option = Console.ReadLine().ToLower();
            Console.WriteLine();
            return option;
        }
    }
}
