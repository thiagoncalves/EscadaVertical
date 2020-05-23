using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscadaVertical
{
    class Program
    {
        static void Main(string[] args)
        {
            string p1;

            Console.Write("Escreva uma palavra: ");
            p1 = Console.ReadLine().ToUpper();

            EscadaSobe(p1);
            EscadaDesce(p1);

            Console.ReadLine();

            Quadrado(p1);

            Console.ReadLine();

            int raio = 10;
            double reacao = 2;
            double a = reacao * raio;
            double b = raio;

            for (int i = -raio; i <= raio; i++)
            {
                for (double x = -a; x <= a; x++)
                {
                    double d = (x / a) * (x / a) + (i / b) * (i / b);
                    if (d > 0.9 && d < 1.2)
                        Console.Write("0");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Read();
        }


        public static void EscadaSobe(string p1)
        {
            int tamanho;
            tamanho = p1.Length;
            for (int i = 0; i <= tamanho; i++)
                Console.WriteLine("\t" + p1.Substring(0, i));
        }

        public static void EscadaDesce(string p1)
        {
            int tamanho;
            tamanho = p1.Length;
            for (int i = 0; i <= tamanho; i++)
                Console.WriteLine("\t" + p1.Substring(i));
        }

        public static void Quadrado(string p1)
        {
            int tamanho;
            tamanho = p1.Length;
            for (int i = (tamanho / 2); i <= tamanho; i++)
                Console.WriteLine("\t" + p1);
        }

        public static void Bola2(string p1)
        {
            int tamanho;
            tamanho = p1.Length;
            for (int i = 2; i <= tamanho; i *= i)
            {
                Console.WriteLine("\t" + p1.Substring(i));
            }
        }

        public static void Bola1(string p1)
        {
            int tamanho;
            tamanho = p1.Length;
            for (int i = 2; i <= tamanho; i *= 2)
            {
                Console.WriteLine("\t" + p1.Substring(0, i));
            }


        }

    }
}
