using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sequencia Fibonacci 

            // Sequencia onde cada numero é a soma dos seus dois antecessores
            // começa com 0 e 1 e o proximo é a soma dos dois ==> 0, 1, 1, 2, 3, 5

            int a = 0, b = 1, c = 0;

            Console.Write("Quantos valores: ");
            int valores = int.Parse(Console.ReadLine()); // informar quantos numeros quer na sequencia
            Console.WriteLine("Sequencia Fibonacci com " + valores + " valores");

            bool numSequencia = false; // comparador de numero

            // colocar a quantidade de valores informados na sequencia fibonacci 
            for (int i = 0; i < valores; i++)
            {
                // Diminuir o numero de 'valores' para se igualar a 'i' e finalizar o loop
                if (i < valores - 1)
                {
                    Console.Write(a + ", ");
                }
                else
                {
                    Console.Write(a);
                }

                // verificar se o numero está na sequencia 
                if (a == valores)
                {
                    numSequencia = true;
                }
                
                // calcular Fibonacci
                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine(" ");

            // condição para mostrar se o numero esta na dentro da sequencia Fibonacci
            if (numSequencia)
            {
                Console.WriteLine("O valor " + valores + " esta na sequencia Fibonacci");
            }
            else
            {
                Console.WriteLine("O valor " + valores + " não esta na sequencia Fibonacci");
            }


            Console.ReadKey();

            // o que a sequencia faz

            /*  
                a = 0 mostra o 'a = 0' na primeora volta
                b = 1
                c = 0

                'c = 0 + 1' c = 1 
                'a = b' a = 1 mostra 
                'b = c' b = 1
                'c = 1 + 1' c = 2
                'a = b' a = 1 mostra
                'b = c' b = 2
                'c = 1 + 2' c = 3
                'a = b' a = 2 mostra
                'b = c' b = 3
                'c = 2 + 3' c = 5
                'a = b' a = 3 mostra
                'b = c' b = 5
                'c = 3 + 5' c = 8
                'a = b' a = 5 mostra
                'b = c' b = 8
                'c = 5 + 8' c = 13
                'a = b' a = 8 mostra
                ...
             */

        }
    }
}
