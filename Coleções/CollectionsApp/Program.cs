using CollectionsApp.Helper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayNumeros = new int[9] { 1, 4, 8, 14, 19, 0, 100, 14, 4 };

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var arrayUnico = arrayNumeros.Distinct().ToArray();


            Console.WriteLine($"Mínimo: {minimo}\nMáximo: {maximo}\nValor Médio: {medio}\nSoma: {soma}");
            Console.WriteLine($"Array original: {string.Join(", ", arrayNumeros)}");
            Console.WriteLine($"Array distinto: {string.Join(", ", arrayUnico)}");
            //var numerosParesQuery =
            //        from num in arrayNumeros
            //        where num % 2 == 0
            //        orderby num
            //        select num;

            //var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            //Console.WriteLine("Números Pares Query: " + string.Join(", ", numerosParesQuery));
            //Console.WriteLine("Números Pares Método: " + string.Join(", ", numerosParesMetodo));

            //Dictionary<string, string> estados = new Dictionary<string, string>();

            //estados.Add("PE", "Pernambuco");
            //estados.Add("RJ", "Rio de Janeiro");
            //estados.Add("BA", "Bahia");

            //foreach (KeyValuePair<string, string> item in estados)
            //{
            //    Console.WriteLine($"Chave: {item.Key}\nValor : {item.Value}\n");
            //}

            //string valorProcurado = "SC";

            ////var teste = estados["SC"];

            //if (estados.TryGetValue(valorProcurado, out string estadoEncontrado)) // tenta achar um valor no dicionário sem interromper o programa caso não encontre e retorna um valor
            //{
            //    Console.WriteLine(estadoEncontrado);
            //}
            //else
            //{
            //    Console.WriteLine($"Chave {valorProcurado} não existe no dicionário");
            //}
            //Console.WriteLine($"Removendo o valor: {valorProcurado}");

            //estados.Remove(valorProcurado);

            //foreach (KeyValuePair<string, string> item in estados)
            //{
            //    Console.WriteLine($"Chave: {item.Key}\nValor : {item.Value}\n");
            //}

            //Console.WriteLine("Valor original: ");
            //Console.WriteLine(estados[valorProcurado]);

            //estados[valorProcurado] = "BA - teste atualização";

            //Console.WriteLine("Valor atualizado.");
            //Console.WriteLine(estados[valorProcurado]);
            //Stack<string> pilhaLivros = new Stack<string>();

            //pilhaLivros.Push(".Net");
            //pilhaLivros.Push("Algoritimos");
            //pilhaLivros.Push("Programação para Android");
            //pilhaLivros.Push("XML");

            //Console.WriteLine($"Livros para leitura: {pilhaLivros.Count}\n");
            //while (pilhaLivros.Count > 0)
            //{
            //    Console.WriteLine($"Próximo livro para leitura: {pilhaLivros.Peek()}");
            //    Console.WriteLine($"{pilhaLivros.Pop()} Lido com sucesso!\n");
            //}

            //Console.WriteLine($"Livros para leitura: {pilhaLivros.Count}");
            //Queue<string> fila = new Queue<string>();
            //fila.Enqueue("Ery");
            //fila.Enqueue("Luiza");
            //fila.Enqueue("Apolo");

            //Console.WriteLine("Pessoas na fila {0}", fila.Count);
            //while (fila.Count > 0)
            //{
            //    Console.WriteLine($"Vez de: {fila.Peek()}");
            //    Console.WriteLine($"{fila.Dequeue()} atendido"); //remove de acordo com a estrutura de repetição criada, sempre que o loop se repete, remove o elemento atual da fila
            //}
            //Console.WriteLine("Pessoas na fila {0}", fila.Count);
            //OperacoesLista opl = new OperacoesLista();
            //List<string> estados = new List<string>();
            //string[] estadoArray = new string[2] { "SC", "MT" };

            //estados.Add("SP");
            //estados.Add("PE");
            //estados.Add("MG");
            //estados.Add("RJ");

            //Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}\n");

            //opl.ImprimirListaString(estados);

            ////Console.WriteLine("\nRemovendo o elemento.\n");

            ////estados.Remove("PE"); //remove o elemento da lista com base no valor citado

            ////estados.AddRange(estadoArray); //adiciona uma coleção ao final da coleção escolhida podendo ser também por array
            //estados.Insert(1, "CE");

            //opl.ImprimirListaString(estados);   

            //OperacoesArray op = new OperacoesArray();
            //int[] array = new int[5] { 4, 6, 5, 1, 8 };
            //int[] arrayCopy = new int[10];
            //string[] arrayString = op.ConvertToStringArray(array);

            //int valorProcurado = 6;

            //Console.WriteLine($"Capacidade atual do array: {array.Length}");

            //op.RedimensionarArray(ref array, array.Length * 2);

            //Console.WriteLine($"Capacidade atual pós redimensionamento do array: {array.Length}");

            //int indice = op.ObterIndice(array, valorProcurado);

            //if (indice > -1)
            //{
            //    Console.WriteLine($"O índice do elemento {valorProcurado} é: {indice}");
            //}
            //else
            //{
            //    Console.WriteLine("Valor não existente no array");
            //}
            //int valorAchado = op.ObterValor(array, valorProcurado);

            //if (valorAchado > 0)
            //{
            //    Console.WriteLine("Encontrei o valor");
            //}
            //else
            //{
            //    Console.WriteLine("Não encontrei o valor");
            //}

            //bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);
            //if (todosMaiorQue)
            //{
            //    Console.WriteLine("Todos os valores são maior que: {0}", valorProcurado);
            //}
            //else
            //{
            //    Console.WriteLine("Existe valores que não são maiores de que {0}", valorProcurado);
            //}
            //bool existe = op.Existe(array, valorProcurado);

            //if (existe)
            //{
            //    Console.WriteLine("Encontrei o valor: {0}", valorProcurado);
            //}
            //else
            //{
            //    Console.WriteLine("Não encontrei o valor: {0}", valorProcurado);
            //}
            //Console.WriteLine("Array Original");
            //op.ImprimirArray(array);

            //op.OrdenarBubbleSort(ref array);
            //op.Ordenar(ref array);

            //Console.WriteLine("Array Ordenado!");
            //op.ImprimirArray(array);

            //Console.WriteLine("Array antes da cópia!");
            //op.ImprimirArray(arrayCopy);

            //op.Copiar(ref array, ref arrayCopy);
            //Console.WriteLine("Array após cópia!");

            //op.ImprimirArray(arrayCopy);

            //int[,] matriz = new int[4, 2]
            //{
            //    {15,8},
            //    {10,84},
            //    {18,89},
            //    {88,88}
            //};

            //for (int i = 0; i < matriz.GetLength(0); i++)//pega a quantidade de linhas
            //{
            //    for (int y = 0; y < matriz.GetLength(1); y++)//pega a quantidade de colunas
            //    {
            //        Console.WriteLine(matriz[i,y]);
            //    }
            //}
            //int[] numeros = new int[4];

            //numeros[0] = 15;
            //numeros[1] = 11;
            //numeros[2] = 16;
            //numeros[3] = 15;

            //Console.WriteLine("Percorrendo com for");
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}

            //Console.WriteLine("Percorrendo com foreach");
            //foreach (var item in numeros)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
