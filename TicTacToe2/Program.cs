﻿// See https://aka.ms/new-console-template for more information
using Baseline.ImTools;

int[] board = new int[9];
board[0] = 0;
board[1] = 0;
board[2] = 0;
board[3] = 0;
board[4] = 2;
board[5] = 0;
board[6] = 0;
board[7] = 0;
board[8] = 1;

for (int i = 0; i < 9; i++)
{
    //Print the board.
    // Console.WriteLine("Squre" + i + "contains" + board[i]);

    //Print x or o for each squre.
    // 0 means empty. 1 means player 1 (X) 2 means player 2 (O)

    if (board[i] == 0)
    {
        Console.Write(".");
       
    }
    if (board[i] == 1)
    {
        Console.Write("X");

    }
    if (board[i] == 2)
    {
        Console.Write("O");

    }
}      //print new line every 3rd parts
         if(i

      

