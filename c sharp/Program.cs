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
                    Console.WriteLine("Primerio");
                    break;
                case 2:
                    Console.WriteLine("Segundo");
                    break;
                case 3:
                    Console.WriteLine("Terceiro");
                    break;
                case 4:
                    Console.WriteLine("Quarto");
                    break;
                default:
                    Console.WriteLine("Opção Inválida!!!");
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
            Console.WriteLine("{0}{1}", teste.PadLeft(direita, ' '), test.PadRight(esquerda-1, ' '));
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
            foreach (string item in lista)
            {
                Console.WriteLine($"{c} - {item}");
                c++;
            }
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
