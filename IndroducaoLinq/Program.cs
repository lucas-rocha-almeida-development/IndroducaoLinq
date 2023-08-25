using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndroducaoLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Implementação do Linq c#
             1º criar uma data source (coleção,array,recurso de E/S ,etc)
             2ºDefinir Query
            3ºExecutar Query (foreach ou alguma operação terminal) Execution*/

            //1ª especificar um data souce
            int[] numbers = new int[] { 1, 2,3,4,5 };//fonte de dados ou data source


            ////2ª Definir a consulta query
            //suponhamos que iremos pegar todo numero par do meu vetor "NUMBERS" e multiplica-lo por 10
            var result = numbers.Where(x => x % 2 == 0)
                .Select(X => X * 10);//coleção contendo apenas numeros pares


            //3ª executar a consulta (forçar a execução da consulta atraves do Foreach
            foreach (int x in result) {
                Console.WriteLine(x);
            }

        }
    }
}
