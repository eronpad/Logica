using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Cryptography;
using System.CodeDom;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Par ou Ímpar");
            Console.WriteLine("2 - Ordem de 3 Números");
            Console.WriteLine("3 - Contagem até 100");
            Console.WriteLine("4 - Soma de Números Positivos");
            Console.WriteLine("5 - (Não utilizado/É o proprio lugar que estamos...)");
            Console.WriteLine("6 - Tabuada");
            Console.WriteLine("7 - Contagem Regressiva");
            Console.WriteLine("8 - Média de Notas");
            Console.WriteLine("9 - Login");
            Console.WriteLine("10 - Calculadora");
            Console.Write("Escolha uma opção: ");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear() ;
                    ImparPar();
                    break;
                case "2":
                    Console.Clear();
                    TresNumeros();
                    break;
                case "3":
                    Console.Clear();
                    Contagem();
                    break;
                case "4":
                    Console.Clear();
                    SomaPositivos();
                    break;
                case "6":
                    Console.Clear();
                    Tabuada();
                    break;
                case "7":
                    Console.Clear();
                    ContagemRegressiva();
                    break;
                case "8":
                    Console.Clear();
                    MediaNotas();
                    break;
                case "9":
                    Console.Clear();
                    Login();
                    break;
                case "10":
                    Console.Clear();
                    Calculadora();
                    break;

            }
        }

        static void ImparPar()
        {
            int num, resp;
            Console.WriteLine("Digite um número inteiro e positivo para ver se é par ou impar:");
            num = int.Parse(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine("Digite um Número POSITIVO e INTEIRO");
            }
            else
            {
                resp = num % 2;
                if (resp == 0)
                { Console.WriteLine("É Par"); }
                else
                {
                    Console.WriteLine("É Impar");
                }
            }
        }

        static void TresNumeros()
        {
            int num, num2, num3;
            Console.WriteLine("Digite o primeiro número:");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número:");
            num3 = int.Parse(Console.ReadLine());
            int menor = num;
            int maior = num;
            int meio;
            // descobrir o menor
            if (num2 < menor)
            {
                menor = num2;
            }
            if (num3 < menor)
            {
                menor = num3;
                // descobrir o maior
                if (num2 > maior)
                {
                    maior = num2;
                }
                if (num3 > maior)
                {
                    maior = num3;
                }
                // descobrir o número do meio
                meio = num + num2 + num3 - maior - menor;
                Console.WriteLine($"Ordem: {maior} -> {meio} -> {menor}");

                if (num == num2 || num == num3 || num2 == num3)
                {
                    Console.WriteLine("Existem números iguais.");
                }

                Console.ReadKey();
            }
        }

        static void Contagem()
        {
            List<int> numeros = new List<int>();

            Console.WriteLine("Contando até 100");
            for (int n = 1; n <= 100; n++)
            {
                numeros.Add(n);
                Console.WriteLine(n);
                Thread.Sleep(150);
            }
            Console.WriteLine("Divisíveis por 3 e 5:");
            foreach (int n in numeros)
            {
                if (n % 3 == 0 && n % 5 == 0)
                {
                    Console.WriteLine(n);
                    Thread.Sleep(200);
                }
            }
        }

        static void SomaPositivos()
        {
            int num = 0;
            int soma = 0;

            Console.WriteLine("Digite números positivos (negativo para parar):");

            while (num >= 0)
            {
                num = int.Parse(Console.ReadLine());

                if (num >= 0)
                {
                    soma += num;
                }
            }

            Console.WriteLine($"Soma total: {soma}");
        }

        static void Tabuada()
        {
            Console.WriteLine("Digite um número:");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }

        static void ContagemRegressiva()
        {
            int n = 60;

            do
            {
                Console.WriteLine(n);
                n--;
                Thread.Sleep(1000);
            }
            while (n >= 0);

            Console.WriteLine("Lançar foguete!");
        }
        static void MediaNotas()
        {
            double nota = 0;
            double soma = 0;
            int contador = 0;

            Console.WriteLine("Digite as notas (negativo para parar):");

            while (nota >= 0 && nota <= 10)
            {
                nota = double.Parse(Console.ReadLine());

                if (nota >= 0)
                {
                    soma += nota;
                    contador++;
                }
            }

            double media = soma / contador;

            Console.WriteLine($"Média: {media}");

            if (media >= 6)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
        static void Login()
        {
            string usuarioCorreto = "admin";
            string senhaCorreta = "1234";

            string usuario;
            string senha;

            do
            {
                Console.Write("Usuário: ");
                usuario = Console.ReadLine();

                Console.Write("Senha: ");
                senha = Console.ReadLine();

                if (usuario != usuarioCorreto || senha != senhaCorreta)
                {
                    Console.WriteLine("Login incorreto, tente novamente.");
                }

            } while (usuario != usuarioCorreto || senha != senhaCorreta);

            Console.WriteLine("Login realizado com sucesso!");
        }
        static void Calculadora()
        {
            Console.WriteLine("Digite o primeiro número:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação (+, -, *, /):");
            string op = Console.ReadLine();

            if (op == "+")
            {
                Console.WriteLine($"Resultado: {n1 + n2}");
            }
            else if (op == "-")
            {
                Console.WriteLine($"Resultado: {n1 - n2}");
            }
            else if (op == "*")
            {
                Console.WriteLine($"Resultado: {n1 * n2}");
            }
            else if (op == "/")
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Erro: divisão por zero.");
                }
                else
                {
                    Console.WriteLine($"Resultado: {n1 / n2}");
                }
            }
            else
            {
                Console.WriteLine("Operação inválida.");
            }
        }
    }
}