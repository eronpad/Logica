using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Leandro_Menu_Func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op, t;
            do
            {
                Console.Clear();
                Console.WriteLine("\nM  e  n  u  ");
                Console.WriteLine("================");

                Console.WriteLine("Escolha sua matematica: ");
                Console.WriteLine("1-Tabuada");
                Console.WriteLine("2-Fatorial");
                Console.WriteLine("3-Bhaskara");
                Console.WriteLine("4-Numeros Primo");
                Console.WriteLine("5-Sair");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1: Tabuada(); break;
                    case 2: Fatorial(); break;
                    case 3: Bhaskara(); break;
                    case 4: NumeroPrimo(); break;
                    case 5: Environment.Exit(0); break;
                }
            }
            while (true);
            
        }


        static void Tabuada()
        {
            double a, b, r;
            Console.WriteLine("--- Calculadora de Tabuada ---");
            Console.WriteLine("Digite o numero para fazer a tabuada: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero para qual você queira que a tabuada vá: ");
            b = double.Parse(Console.ReadLine());

            for (int i = 0; i <= b; i++)
            {
                r = a * i;
                Thread.Sleep(150);
                Console.WriteLine($"{a} X {i} = {r}");
            }
            Console.ReadKey();
        }

        static void Fatorial()
        {
            
            int a = 0, r;
            Console.WriteLine("--- Calculadora de Fatorial ---");
            Console.WriteLine("Digite o numero para fazer o FATORIAL: :");
            a = int.Parse(Console.ReadLine());
            r = a;

            for (int i = a - 1; i > 1; i--)
            {
                r *= i;
            }
            Console.WriteLine($"{r}");
            Console.ReadKey();
        }
        static void Bhaskara()
        {
            double a, b, c;

            Console.WriteLine("--- Calculadora de Bhaskara ---");
            Console.Write("Digite o valor de a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de c: ");
            c = double.Parse(Console.ReadLine());

            double delta = (b * b) - (4 * a * c);
            Console.WriteLine($"\nDelta: {delta}");

            if (delta >= 0 && a != 0)
            {
                double raizDelta = Math.Sqrt(delta);
             
                double x1 = (-b + raizDelta) / (2 * a);
                double x2 = (-b - raizDelta) / (2 * a);

                Console.WriteLine($"X1 = {x1}");
                Console.WriteLine($"X2 = {x2}");
            }
            else
            {
                Console.WriteLine("A equação não possui raízes reais (delta < 0 ou a = 0).");
            }

            
        }
        static void NumeroPrimo()
        {
            int a = 0, b = 0;
            Console.WriteLine("--- Numero Primo ---");
            Console.WriteLine("Digite o numero para saber se é primo: :");
            a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                    b++;
            }

            if(b == 2)
            {
                Console.WriteLine($"O Numero {a} é primo");
            }
            else
            {
                Console.WriteLine("Nao é primo");
            }
            Console.ReadKey();
        }

    }
    }