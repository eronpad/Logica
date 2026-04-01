using Microsoft.SqlServer.Server;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Leandro_11_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrocaMaster();
        }

        static void angulo() 
        {
            double ang, seno;
            Console.WriteLine("Entre com o ângulo (em radianos)");
            ang = Convert.ToDouble(Console.ReadLine());
            seno = Math.Sin(ang);
            Console.WriteLine($"O Seno de {seno}");
            Console.ReadKey();

        }

        static void raiz()
        {
            double num, raiz, quadrado;
            Console.WriteLine($"Digite o numero:");
            num = Convert.ToDouble(Console.ReadLine());
            raiz = Math.Sqrt(num);
            quadrado = Math.Pow(num, 2);
            Console.WriteLine($"O Quadrado {quadrado}. A Raiz é {raiz}");
            Console.ReadKey();
        }

        static void delta()
        {
            double a, b, c, delta, x;
            Console.WriteLine("Equação de Segundo Grau");
            Console.WriteLine("Digite o valor de A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            c = Convert.ToDouble(Console.ReadLine());
            delta = Math.Pow(b, 2) - (4 * a * c);
            Console.WriteLine($"{delta}");
            if (delta < 0)
            {
                Console.WriteLine("Não existe raizes reais");
            }
            else if (delta == 0)
            {
                x = (-b) / (2 * a);
                Console.WriteLine($"Delta igual a zero só existe uma raiz {x:0.00}");
            }
            else
            {
                x = ((-b) + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"X1: {x:0.00}");
                x = ((-b) - Math.Sqrt(delta)) / (2*a);
                Console.WriteLine($"X2: {x:0.00}");
            }
            Console.ReadKey();

        }

        static void alfanumerico()
        {
            string nome;
            int idade;
            Console.WriteLine("Digite seu Nome: ");
            nome = Console.ReadLine();
            nome = nome.ToUpper();
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Bom dia {nome}, você tem {idade} anos!.");
            Console.ReadKey();
        }

        static void frase()
        {
            string fra;
            int pos;
            Console.WriteLine("Digite uma frase: ");
            fra = Console.ReadLine();
            fra = fra.ToUpper();
            pos = fra.IndexOf("B");
            Console.WriteLine($"A posicção da letra 'b' é {pos}");
            Console.ReadKey();
        }

        static void frasecompleto()
        {
            string completo, parte;
            Console.WriteLine("Digite uma Frase :");
            completo = Console.ReadLine();
            parte = completo.Substring(4,8);
            Console.WriteLine($"A parte quebrada é {parte}");
            Console.ReadKey();
        }

        static void NomeSobrenome()
        {
            string nomecomp, part2, part3;
            int part;
            Console.WriteLine("Digite seu nome:");
            nomecomp = Console.ReadLine();
            part = nomecomp.IndexOf(" ");
            part2 = nomecomp.Substring(0, part);
            part3 = nomecomp.Substring(part);
            Console.WriteLine($"Seu nome é:{part2.Trim()}");
            Console.WriteLine($"Seu Sobrenome é:{part3.Trim()} ");
            Console.ReadKey();  
        }

        static void Troca()
        {
            string fra;
            Console.WriteLine("Digite uma palavra: ");
            fra = Console.ReadLine();
            fra = fra.Replace("o","i");
            Console.WriteLine($"Sua 'nova' Palavra é: {fra}");
            Console.ReadKey();
        }

        static void TrocaMaster()
        {
            string palavra, sub, rep;
            Console.WriteLine("Digite Uma Palavra: ");
            palavra = Console.ReadLine();
            Console.WriteLine("Qual letra você quer buscar da sua palavra? ");
            sub = Console.ReadLine();
            Console.WriteLine("Digite a letra para substituir: ");
            rep = Console.ReadLine();
            palavra = palavra.Replace(sub, rep);
            Console.WriteLine($"Sua nova palavra: {palavra}");
            Console.ReadKey();
        }
    }   
}
