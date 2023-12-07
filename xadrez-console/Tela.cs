﻿using tabuleiro;
using System;
using xadrez_console.tabuleiro;
namespace xadrez_console
{
    internal class Tela

    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for(int i = 0; i < tab.linhas; i++)
            {
                for(int j = 0; j < tab.linhas; j++)
                {
                    if(tab.peca(i, j) == null)
                    {
                        Console.Write(" - ");
                    }
                    else
                    {
                        Console.Write(tab.peca(i, j) + "");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}