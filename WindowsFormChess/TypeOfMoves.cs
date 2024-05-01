using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_game
{
    class TypeOfMoves
    {
        public int[,] WhiteDiagonalMoves(int[,] Table, int[,] PossibleMoves, int i, int j)
        {
            int b;
            for (b = 1; b < 8; b++)
            {
                if (i - b >= 0 && j - b >= 0)
                {
                    if (Table[i - b, j - b] < 10)
                    {
                        PossibleMoves[i - b, j - b] = 2;
                        if (Table[i - b, j - b] < 10 && Table[i - b, j - b] != 0) break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            //up
            for (b = 1; b < 8; b++)
            {
                if (i - b >= 0 && j + b < 8)
                {
                    if (Table[i - b, j + b] < 10)
                    {
                        PossibleMoves[i - b, j + b] = 2;
                        if (Table[i - b, j + b] < 10 && Table[i - b, j + b] != 0) break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            //up left
            for (b = 1; b < 8; b++)
            {
                if (i + b < 8 && j - b >= 0)
                {
                    if (Table[i + b, j - b] < 10)
                    {
                        PossibleMoves[i + b, j - b] = 2;
                        if (Table[i + b, j - b] < 10 && Table[i + b, j - b] != 0) break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            //up right
            for (b = 1; b < 8; b++)
            {
                if (i + b < 8 && j + b < 8)
                {
                    if (Table[i + b, j + b] < 10)
                    {
                        PossibleMoves[i + b, j + b] = 2;
                        if (Table[i + b, j + b] < 10 && Table[i + b, j + b] != 0) break;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return PossibleMoves;
        }
        public int[,] WhiteVerticalAndHorizontalMoves(int[,] Table,int[,] PossibleMoves, int i, int j)
        {
            int b;
            //upward movement until collision
            for (b = i - 1; b > -1; b--)
            {
                if (Table[b, j] == 0)
                {
                    PossibleMoves[b, j] = 2;
                }
                else
                {
                    if (Table[b, j] > 10)
                    {
                        break;
                    }
                    else
                    {
                        PossibleMoves[b, j] = 2;
                        break;
                    }
                }
            }
            //downward movement until collision
            for (b = i + 1; b < 8; b++)
            {
                if (Table[b, j] == 0)
                {
                    PossibleMoves[b, j] = 2;
                }
                else
                {
                    if (Table[b, j] > 10)
                    {
                        break;
                    }
                    else
                    {
                        PossibleMoves[b, j] = 2;
                        break;
                    }
                }
            }
            //leftward movement until collision
            for (b = j - 1; b > -1; b--)
            {
                if (Table[i, b] == 0)
                {
                    PossibleMoves[i, b] = 2;
                }
                else
                {
                    if (Table[i, b] > 10)
                    {
                        break;
                    }
                    else
                    {
                        PossibleMoves[i, b] = 2;
                        break;
                    }
                }
            }
            //rightward movement until collision
            for (b = j + 1; b < 8; b++)
            {
                if (Table[i, b] == 0)
                {
                    PossibleMoves[i, b] = 2;
                }
                else
                {
                    if (Table[i, b] > 10)
                    {
                        break;
                    }
                    else
                    {
                        PossibleMoves[i, b] = 2;
                        break;
                    }
                }
            }

            return PossibleMoves;
        }
        public int[,] WhiteHorseMoves(int[,] Table,int[,] PossibleMoves, int i, int j)
        {
            //upward movement in standing L shape
            if (i - 2 >= 0)
            {
                if (j - 1 >= 0)
                {
                    if (Table[i - 2, j - 1] < 10)
                    {
                        PossibleMoves[i - 2, j - 1] = 2;
                    }
                }


                if (j + 1 < 8)
                {
                    if (Table[i - 2, j + 1] < 10)
                    {
                        PossibleMoves[i - 2, j + 1] = 2;
                    }
                }
            }
            //downward movement in standing L shape
            if (i + 2 < 8)
            {
                if (j - 1 >= 0)
                {
                    if (Table[i + 2, j - 1] < 10)
                    {
                        PossibleMoves[i + 2, j - 1] = 2;
                    }
                }


                if (j + 1 < 8)
                {
                    if (Table[i + 2, j + 1] < 10)
                    {
                        PossibleMoves[i + 2, j + 1] = 2;
                    }
                }
            }
            //upward movement in lying L shape
            if (j - 2 >= 0)
            {
                if (i - 1 >= 0)
                {
                    if (Table[i - 1, j - 2] < 10)
                    {
                        PossibleMoves[i - 1, j - 2] = 2;
                    }
                }
                if (i + 1 < 8)
                {
                    if (Table[i + 1, j - 2] < 10)
                    {
                        PossibleMoves[i + 1, j - 2] = 2;
                    }
                }
            }
            //downward movement in lying L shape
            if (j + 2 < 8)
            {
                if (i - 1 >= 0)
                {
                    if (Table[i - 1, j + 2] < 10)
                    {
                        PossibleMoves[i - 1, j + 2] = 2;
                    }
                }
                if (i + 1 < 8)
                {
                    if (Table[i + 1, j + 2] < 10)
                    {
                        PossibleMoves[i + 1, j + 2] = 2;
                    }
                }
            }

            return PossibleMoves;
        }
        public int[,] BlackDiagonalMoves(int[,] Table, int[,] PossibleMoves, int i, int j)
        {
            int b;
            //up left
            for (b = 1; b < 8; b++)
            {
                if (i - b >= 0 && j - b >= 0)
                {
                    if (Table[i - b, j - b] == 0 || Table[i - b, j - b] > 10)
                    {
                        PossibleMoves[i - b, j - b] = 2; if (Table[i - b, j - b] > 10) break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            //up right
            for (b = 1; b < 8; b++)
            {
                if (i - b >= 0 && j + b < 8)
                {
                    if (Table[i - b, j + b] == 0 || Table[i - b, j + b] > 10)
                    {
                        PossibleMoves[i - b, j + b] = 2; if (Table[i - b, j + b] > 10) break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            //down left
            for (b = 1; b < 8; b++)
            {
                if (i + b < 8 && j - b >= 0)
                {
                    if (Table[i + b, j - b] == 0 || Table[i + b, j - b] > 10)
                    {
                        PossibleMoves[i + b, j - b] = 2; if (Table[i + b, j - b] > 10) break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            //down right
            for (b = 1; b < 8; b++)
            {
                if (i + b < 8 && j + b < 8)
                {
                    if (Table[i + b, j + b] == 0 || Table[i + b, j + b] > 10)
                    {
                        PossibleMoves[i + b, j + b] = 2; if (Table[i + b, j + b] > 10) break;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return PossibleMoves;
        }
        public int[,] BlackVerticalAndHorizontalMoves(int[,] Table, int[,] PossibleMoves, int i, int j)
        {
            int b;
            for (b = i - 1; b > -1; b--)
            {
                if (Table[b, j] == 0)
                {
                    PossibleMoves[b, j] = 2;
                }
                else
                {
                    if (Table[b, j] < 10)
                    {
                        break;
                    }
                    else
                    {
                        PossibleMoves[b, j] = 2;
                        break;
                    }
                }
            }
            //downward movement until collision
            for (b = i + 1; b < 8; b++)
            {
                if (Table[b, j] == 0)
                {
                    PossibleMoves[b, j] = 2;
                }
                else
                {
                    if (Table[b, j] < 10)
                    {
                        break;
                    }
                    else
                    {
                        PossibleMoves[b, j] = 2;
                        break;
                    }
                }
            }
            //leftward movement until collision
            for (b = j - 1; b > -1; b--)
            {
                if (Table[i, b] == 0)
                {
                    PossibleMoves[i, b] = 2;
                }
                else
                {
                    if (Table[i, b] < 10)
                    {
                        break;
                    }
                    else
                    {
                        PossibleMoves[i, b] = 2;
                        break;
                    }
                }
            }
            //rightward movement until collision
            for (b = j + 1; b < 8; b++)
            {
                if (Table[i, b] == 0)
                {
                    PossibleMoves[i, b] = 2;
                }
                else
                {
                    if (Table[i, b] < 10)
                    {
                        break;
                    }
                    else
                    {
                        PossibleMoves[i, b] = 2;
                        break;
                    }
                }
            }

            return PossibleMoves;
        }
        public int[,] BlackHorseMoves(int[,] Table, int[,] PossibleMoves, int i, int j)
        {
            //upward movement in standing L shape
            if (i - 2 >= 0)
            {
                if (j - 1 >= 0)
                {
                    if (Table[i - 2, j - 1] == 0 || Table[i - 2, j - 1] > 10)
                    {
                        PossibleMoves[i - 2, j - 1] = 2;
                    }
                }


                if (j + 1 < 8)
                {
                    if (Table[i - 2, j + 1] == 0 || Table[i - 2, j + 1] > 10)
                    {
                        PossibleMoves[i - 2, j + 1] = 2;
                    }
                }
            }
            //downward movement in standing L shape
            if (i + 2 < 8)
            {
                if (j - 1 >= 0)
                {
                    if (Table[i + 2, j - 1] == 0 || Table[i + 2, j - 1] > 10)
                    {
                        PossibleMoves[i + 2, j - 1] = 2;
                    }
                }


                if (j + 1 < 8)
                {
                    if (Table[i + 2, j + 1] == 0 || Table[i + 2, j + 1] > 10)
                    {
                        PossibleMoves[i + 2, j + 1] = 2;
                    }
                }
            }
            //upward movement in lying L shape
            if (j - 2 >= 0)
            {
                if (i - 1 >= 0)
                {
                    if (Table[i - 1, j - 2] == 0 || Table[i - 1, j - 2] > 10)
                    {
                        PossibleMoves[i - 1, j - 2] = 2;
                    }
                }
                if (i + 1 < 8)
                {
                    if (Table[i + 1, j - 2] == 0 || Table[i + 1, j - 2] > 10)
                    {
                        PossibleMoves[i + 1, j - 2] = 2;
                    }
                }
            }
            //downward movement in lying L shape
            if (j + 2 < 8)
            {
                if (i - 1 >= 0)
                {
                    if (Table[i - 1, j + 2] == 0 || Table[i - 1, j + 2] > 10)
                    {
                        PossibleMoves[i - 1, j + 2] = 2;
                    }
                }
                if (i + 1 < 8)
                {
                    if (Table[i + 1, j + 2] == 0 || Table[i + 1, j + 2] > 10)
                    {
                        PossibleMoves[i + 1, j + 2] = 2;
                    }
                }
            }

            return PossibleMoves;
        }
    }
}
