﻿using System;
using tabuleiro;
using xadrez_console;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {

            PosicaoXadrez pos = new PosicaoXadrez('c', 1);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());
            

            Console.ReadLine();
        }
    }
}
