﻿using System;
using System.Threading;
using System.Collections.Generic;
namespace c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            sublinhado("Mo");
            game("MONTEIRO");
            cabecalho("JOGO DA FORCA");
            menu("Animais", "Peixes", "Nome", "Series");
            linha();
            int op = leiaOp(1, 4);
            Thread.Sleep(1000);
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
        static void game(string txt)
        {
            List<char> listaTexto = new List<char>();
            List<char> listaSublinhada = new List<char>();
            string texto = txt;
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
        static List<char> sublinhado(string texto)
        {
            List<char> listaSublinhada = new List<char>();
            for (int i = 0; i < texto.Length; i++)
            {
                listaSublinhada.Add('_');
            }
            
            return listaSublinhada;
        }
    }
}
