using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        // Função principal.
        static void Main(string[] args)
        {

            Console.WriteLine("Qual operação deseja fazer: ");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão \n");

            // Operação.
            int op = int.Parse(Console.ReadLine());

            // Primeiro numero.
            Console.WriteLine("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());

            // Segundo numero.
            Console.WriteLine("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            // Resultado.
            int result = 0;

            // Verificar qual operação o usuario deseja fazer.
            switch (op)
            {
                case 1:
                    {
                        result = Adicao(num1, num2);
                        break;
                    }

                case 2:
                    {
                        result = Sub(num1, num2);
                        break;
                    }
                case 3:
                    {
                        result = Mult(num1, num2);
                        break;
                    }
                case 4:
                    {
                        result = Div(num1, num2);
                        break;
                    }

                default:
                    Console.WriteLine("Numero invalido, digite outro numero");
                    break;
            }

            // Mostrar o resultado.
            Console.WriteLine("O resultado da operação com os numeros {0} e {1} é: {2}", num1, num2, result);

            Console.ReadLine();
        }

        // Funçoes das operação.

        // Adição.
        public static int Adicao (int num1, int num2)
        {
            int result = num1 + num2;

            return result;

        }

        // Subtração.
        public static int Sub(int num1, int num2)
        {
            int result = num1 - num2;

            return result;

        }

        // Multiplicação.
        public static int Mult(int num1, int num2)
        {
            int result = num1 * num2;

            return result;

        }

        // Divisão.
        public static int Div(int num1, int num2)
        {
            int result = num1 / num2;

            return result;

        }

    }

}
