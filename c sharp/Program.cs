using System;
using System.Threading;
namespace c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string cont = "";
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string nome = "REDNEY";
            string nomeMudado = nome;
            string underline = "_";
            for(int c = 0; c < nome.Length; c++)
            {
                for (int i = 0; i < 26; i++)
                {
                    if(nome[c] == alfabeto[i])
                    {
                        nomeMudado = nomeMudado.Replace(nome[c], underline[0]);
                    }
                }
            }
            string teste = nomeMudado;

            //Console.WriteLine(nome);
            //Console.WriteLine(nomeMudado);
            //Console.WriteLine(teste);
            for (int i = 0; i < nome.Length; i++)
            {
                Console.Write($"{nomeMudado[i]} ");
            }
            Console.WriteLine();
            string mudar = "R";
            for (int i = 0; i < nome.Length; i++)
            {
                if(nome[i] == mudar[0])
                {
                    teste = nome;
                    cont += nome[i];
                }
            }
            for (int i = 0; i < nome.Length; i++)
            {
                if(nome[i] == mudar[0])
                {
                    nomeMudado = nome;
                }
            }
            Console.WriteLine(teste);
            Console.WriteLine(nome);
            Console.WriteLine(nomeMudado);
            Console.WriteLine(cont);
            for (int c = 0; c < teste.Length; c++)
            {
                for (int i = 0; i < nome.Length; i++)
                {
                    if(cont[c] == nome[i])
                    {
                        teste = teste.Replace("");
                    }
                }
            }



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
