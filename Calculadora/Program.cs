using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            String input;
            double first,second;
            int op;
            bool calculate = true;

            Console.WriteLine("-----Calculadora----");
            while (calculate)
            {
                firstNum:
                Console.WriteLine("Digite o primeiro número");
                input = Console.ReadLine();
                if(!Double.TryParse(input, out first))
                {
                    Console.WriteLine("Número inválido");
                    goto firstNum;
                }

                secondNum:
                Console.WriteLine("Digite o segundo número");
                input = Console.ReadLine();
                if(!Double.TryParse(input, out second))
                {
                    Console.WriteLine("Número inválido");
                    goto secondNum;
                }

                Console.WriteLine("Selecione uma operação \n 1)Somar \n 2)Subtrair \n 3)Multiplicar \n 4)Dividir \n 0)Sair");
                input = Console.ReadLine();
                if(!Int32.TryParse(input, out op))
                {
                    Console.WriteLine("Operação inválida");
                }

                switch (op)
                {
                    case 0:
                        calculate = false;
                        break;
                    case 1:
                        Console.WriteLine("A soma dos números é " + Sum(first, second));
                        break;
                    case 2:
                        Console.WriteLine("A subtração dos números é " + Sub(first, second));
                        break;
                    case 3:
                        Console.WriteLine("O produto dos números é " + Multiply(first, second));
                        break;
                    case 4:
                        Console.WriteLine("A divisão dos números é " + Divide(first, second));
                        break;
                }

                cont:
                Console.WriteLine("Deseja continuar? S/N");
                input = Console.ReadLine().ToUpper();
                if(input == "S")
                {
                    calculate = true;
                }else if(input == "N")
                {
                    calculate = false;
                }
                else
                {
                    Console.WriteLine("Operação inválida.");
                    goto cont;
                }
            }
        }

        static double Sum(double a, double b)
        {
            return a + b;
        }

        static double Sub(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
