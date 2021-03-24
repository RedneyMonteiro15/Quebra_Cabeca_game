using System;
using System.Threading;
using System.Collections.Generic;
namespace c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int teste;

            List<string> listaAnimais = new List<string>(){"ABELHA", "AGUIA", "ARANHA", "ATUM", "AVESTRUZ", "BALEIA", "BORBOLETA", "BURRO", "CABRA", "CACHORRO", "CAMELO", "CAVALO", "COELHO", "CORVO"};
            List<string> listaNome = new List<string>(){"ALANAH", "SAYURI", "DANIA", "TANIA", "MANUEL", "VANISIA", "ADRIANO", "EDNEY", "SIDNEY", "BRANDAO"};
            List<string> listaSeries = new List<string>(){"Redney", "Manuel"};
            cabecalho("JOGO DA FORCA");
            menu("Animais", "Nome");
            int op = leiaOp(1, 2);
            Thread.Sleep(1000);
            Console.Clear();
            switch (op)
            {
                case 1:
                    teste = aleatorio.Next(0, listaAnimais.Count - 1);
                    game(listaAnimais[teste], "ANIMAIS");
                    break;
                case 2:
                    teste = aleatorio.Next(0, listaNome.Count - 1);
                    game(listaNome[teste], "NOME");
                    break;                
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção Inválida!!!");
                    Console.ResetColor();
                    break;
            }
            cabecalho("FIM DO JOGO");
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
            linha();
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
        static void game(string txt, string msg)
        {
            cabecalho(msg);
            List<char> listaTexto = new List<char>();
            List<char> listaSublinhada = new List<char>();
            string texto = txt;
            for (int i = 0; i < texto.Length; i++)
            {
                listaTexto.Add(texto[i]);
                listaSublinhada.Add('_');
            }
            for (int i = 0; i < listaSublinhada.Count; i++)
            {
                Console.Write($"{listaSublinhada[i]} ");
            }
            Console.WriteLine();
            while (true)
            {
                int contV = 0;
                Console.Write("Digite uma Letra: ");
                string teste = (Console.ReadLine()).ToUpper();
                for (int i = 0; i < listaSublinhada.Count; i++)
                {
                    if(listaTexto[i] == teste[0])
                    {
                        listaSublinhada[i] = teste[0];
                    }
                }
                for (int i = 0; i < listaSublinhada.Count; i++)
                {
                    if(listaTexto[i] == listaSublinhada[i])
                    {
                        contV++;
                    }
                }
                Thread.Sleep(1000);
                Console.Clear();
                cabecalho(msg);
                for (int i = 0; i < listaSublinhada.Count; i++)
                {
                    Console.Write($"{listaSublinhada[i]} ");
                }
                Console.WriteLine();
                if(contV == listaTexto.Count)
                {
                    break;
                }
                Thread.Sleep(800);
            }
        }
    
    }
}
