using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsApp.Helper
{
    public class OperacoesArray
    {

        public void OrdenarBubbleSort(ref int[] array)
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        public void ImprimirArray(int[] array)
        {

            var linha = string.Join(", ", array);
                Console.WriteLine(linha);
        }

        public void Ordenar(ref int[] array)
        {
            Array.Sort(array); //Ordena o Array pelo método sort, contém 3 tipos de algoritmos automatizados para melhor performance
        }

        public void Copiar(ref int[] array, ref int[] arrayDestino)
        {
            Array.Copy(array, arrayDestino, array.Length); //referencia por 3 parâmetros o array o array de destino e o tamanho do array pelo .Lenght para cópia completa
        }

        public bool Existe(int[] array, int value)
        {
            return Array.Exists(array, elemento => elemento == value); //retorna um booleano e verifica dentro do array se o elemento existe dado pelo valor
        }

        public bool TodosMaiorQue(int[] array, int value)
        {
            return Array.TrueForAll(array, elemento => elemento > value); //verifica com um retorno booleano se todos os elementos do array são maiores que o valor dado
        }

        public int ObterValor(int[] array, int value)
        {
            return Array.Find(array, element => element == value); //Retorna um inteiro de acordo com a condição element
        }

        public int ObterIndice(int[] array, int value)
        {
            return Array.IndexOf(array, value); //Encontra a posição no array de acordo com um valor dado em inteiro
        }

        public void RedimensionarArray(ref int[] array, int novoTamanho)
        {
            Array.Resize(ref array, novoTamanho); //simplesmente altera o valor do array passando um novo valor como um parâmetro
        }

        public string[] ConvertToStringArray(int[] array)
        {
            return Array.ConvertAll(array, element => element.ToString()); //elemento representa uma posição do array de inteiros e realiza uma conversao para string com o método .ToString
        }
    }
}
