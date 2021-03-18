using System;
using System.Threading;
namespace c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            cabecalho("JOGO DA FORCA");
            menu("Animais", "Peixes", "Nome", "Series");
            linha();
            int op = leiaOp(1, 4);
            Thread.Sleep(1000);
            //Console.Clear();
            switch (op)
            {
                case 1:
                    cabecalho("ANIMAIS");
                    Console.WriteLine("Primerio");
                    break;
                case 2:
                    cabecalho("PEIXES");
                    Console.WriteLine("Segundo");
                    break;
                case 3:
                    cabecalho("NOMES");
                    Console.WriteLine("Terceiro");
                    break;
                case 4:
                    cabecalho("SERIES");
                    Console.WriteLine("Quarto");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção Inválida!!!");
                    Console.ResetColor();
                    break;
            }
        }
        static void linha()
        {
            Console.WriteLine("------------------------------");
        }
        static void center(string teste, int num)
        {
            int total, esquerda, direita;
            string test = "";
            total = num - teste.Length;
            direita = (total / 2) + teste.Length;
            esquerda = num - direita;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}{1}", teste.PadLeft(direita, ' '), test.PadRight(esquerda-1, ' '));
            Console.ResetColor();
        }
        static void cabecalho(string txt)
        {
            linha();
            center(txt, 30);
            linha();
        }
        static void menu(params string[]lista)
        {
            Console.WriteLine("Escolhe sua categoria: ");
            int c = 1;
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (string item in lista)
            {
                Console.WriteLine($"{c} - {item}");
                c++;
            }
            Console.ResetColor();
        }
        static int leiaOp(int inf, int sup)
        {
            while (true)
            {
                Console.Write("Sua opção: ");
                int op = Convert.ToInt32(Console.ReadLine());
                if(op >= inf && op <= sup)
                {
                    return op;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERRO!!! Digite uma opção válida.");
                Console.ResetColor();
            }
        }
    }
}
