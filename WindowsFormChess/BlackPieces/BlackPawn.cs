using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_game
{
    class BlackPawn
    {
        int A;
        int B;
        public int[,] GetPossibleMoves(int[,] Table, int[,] PossibleMoves, int i, int j,bool WhiteTurn,bool OtherPlayerTurn)
        {
            if (WhiteTurn||OtherPlayerTurn)
            {
                return PossibleMoves;
            }
            A = i;
            B = j;
            //Move forward if there is no piece in front
            if (Table[i + 1, j] == 0)
            {
                PossibleMoves[i + 1, j] = 2;
            }
            //Capture opponent's piece to the left
            if (j - 1 >= 0)
            {
                if (Table[i + 1, j - 1] > 10)
                {
                    PossibleMoves[i + 1, j - 1] = 2;
                }
            }
            //Capture opponent's piece to the right
            if (j + 1 < 8)
            {
                if (Table[i + 1, j + 1] > 10)
                {
                    PossibleMoves[i + 1, j + 1] = 2;
                }
            }
            //Double move forward from the starting position if there is no piece in front
            if (i == 1)
            {
                if (Table[i + 1, j] == 0 && Table[i + 2, j] == 0)
                {
                    PossibleMoves[i + 2, j] = 2;
                }
            }
            return PossibleMoves;
        }
        //TODO en passant
        public int[,] IsStale(int[,] Table, int[,] PossibleMoves)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (Table[i, j] == 01)
                    {
                        //Capture opponent's piece to the left
                        if (j - 1 >= 0)
                        {
                            if (Table[i + 1, j - 1] > 10)
                            {
                                PossibleMoves[i + 1, j - 1] = 2;
                            }
                        }
                        //Capture opponent's piece to the right
                        if (j + 1 < 8)
                        {
                            if (Table[i + 1, j + 1] > 10)
                            {
                                PossibleMoves[i + 1, j + 1] = 2;
                            }
                        }
                    }
                }
            }
            return PossibleMoves;
        }

    }
}
