using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contas(5, 5);
            Console.WriteLine("Insira o Primeiro Numero");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Segundo Numero");
            double b = double.Parse(Console.ReadLine());
            teste(a, b);
            Console.ReadKey();
        }

        static void Mensagem(string nome)
        {
            Console.WriteLine($"{nome}");
        }

        static void Contas(double a, double b)
        {
            Console.WriteLine(a + b);
            Console.WriteLine(a / b);
            Console.WriteLine(a * b);
            Console.WriteLine(a - b);
        }

        static void teste(double a , double b)
        {
            double r;
            Console.WriteLine("--------------Resultados---------------");
            Console.WriteLine(r = a + b);
            Console.WriteLine(r = a - b);
            Console.WriteLine(r = a * b);
            Console.WriteLine(r = a / b);
        }
    }
}
