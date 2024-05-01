using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_game
{
    class WhiteKing
    {
        public int[,] GetPossibleMoves(int[,] Table, int[,] PossibleMoves, int i, int j, bool WhiteTurn, bool WhiteKingMoved, bool WhiteRookMoved1, bool WhiteRookMoved2,bool OtherPlayerTurn)
        {
            if (!WhiteTurn|| OtherPlayerTurn)
            {
                return PossibleMoves;
            }
            //left
            if (j - 1 >= 0)
            {
                if (Table[i, j - 1] < 10)
                {
                    PossibleMoves[i, j - 1] = 2;
                }
            }
            //right
            if (j + 1 < 8)
            {
                if (Table[i, j + 1] < 10)
                {
                    PossibleMoves[i, j + 1] = 2;
                }
            }
            //up
            if (i - 1 >= 0)
            {
                if (Table[i - 1, j] < 10)
                {
                    PossibleMoves[i - 1, j] = 2;
                }
            }
            //down
            if (i + 1 < 8)
            {
                if (Table[i + 1, j] < 10)
                {
                    PossibleMoves[i + 1, j] = 2;
                }
            }
            //up left
            if (i - 1 >= 0 && j - 1 >= 0)
            {
                if (Table[i - 1, j - 1] < 10)
                {
                    PossibleMoves[i - 1, j - 1] = 2;
                }
            }
            //up right
            if (i - 1 >= 0 && j + 1 < 8)
            {
                if (Table[i - 1, j + 1] < 10)
                {
                    PossibleMoves[i - 1, j + 1] = 2;
                }
            }
            //down left
            if (i + 1 < 8 && j - 1 >= 0)
            {
                if (Table[i + 1, j - 1] < 10)
                {
                    PossibleMoves[i + 1, j - 1] = 2;
                }
            }
            //down right
            if (i + 1 < 8 && j + 1 < 8)
            {
                if (Table[i + 1, j + 1] < 10)
                {
                    PossibleMoves[i + 1, j + 1] = 2;
                }
            }

            if (WhiteKingMoved && WhiteRookMoved1)
            {
                if (Table[7, 1] == 0 && Table[7, 2] == 0 && Table[7, 3] == 0)
                {
                    PossibleMoves[7, 2] = 2;
                }

            }
            if (WhiteKingMoved && WhiteRookMoved2)
            {
                if (Table[7, 5] == 0 && Table[7, 6] == 0)
                {
                    PossibleMoves[7, 6] = 2;
                }
            }
            return PossibleMoves;
        }
    }
}
