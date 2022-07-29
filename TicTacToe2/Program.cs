// See https://aka.ms/new-console-template for more information
using Baseline.ImTools;
int[] board = new int[9];
board[0] = 0;
board[1] = 0;
board[2] = 0;
board[3] = 0;
board[4] = 0;
board[5] = 0;
board[6] = 0;
board[7] = 0;
board[8] = 0;

int userTurn = -1;
int userTurn2 = -1;
Random rand = new Random();

while (checkForWinner()==0) {
{
    //dont allow userTurn to pick a square already occupied
    while (userTurn == -1 || board[userTurn] != 0)
    {
        Console.WriteLine("Enter a number from 0 to 8");
        userTurn = int.Parse(Console.ReadLine());
        Console.WriteLine("You Type" + userTurn);
    }
    board[userTurn] = 1;
    // dont let userTurn2 pick an invalid square
    while (userTurn2 == -1 || board[userTurn2] != 0)
    {
        userTurn2 = rand.Next(8);

        Console.WriteLine("userTurn2 Chooses" + userTurn2);

    }
    board[userTurn2] = 2;
    printBoard();
    
    {
      Console.WriteLine("player" + checkForWinner() + "won the game"  
    }
    int checkForWInner;
    //return a 0 if nobody won. return the player number if they won.
    //First row.
    if (board[0] == board[1] && board[1] == board[2])

        return board[0];
    return 0;

    //Second row.
    if (board[3] == board[4] && board[4] == board[5])
    {
        return board[4];

    }
    // third row.
    if (board[6] == board[7] && board[7] == board[8])
    {
        return board[6]; 
       
    }   //first column.  
    if (board[0] == board[3] && board[3] == board[6]
    {
         return board[0];

    }   //second column.  
    if (board[1] == board[4] && board[4] == board[7]
    {
         return board[1];


    }   //third column.  
    if (board[2] == board[5] && board[5] == board[8]
    {
         return board[2];

    }   //first diagonal.  
    if (board[0] == board[4] && board[4] == board[8]
    {
         return board[4];


 }   //second diagonal.  
    if (board[2] == board[4] && board[4] == board[8]
    {
         return board[2]






        void printBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                //Print the board.
                // Console.WriteLine("Squre" + i + "contains" + board[i]);

                //Print X or an O for each square
                // 0 means empty. 1 means userTurn (X) 2 means userTurn2 (O)
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

                //print new line every 3rd parts
                if (i == 2 || i == 5 || i == 8)
                {
                    Console.WriteLine();
                }

            }
        }
}
