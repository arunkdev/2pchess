using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace tw0pchess
{
    public class Pawn : ChessPiece
    {
        bool firstMove = true;
        public Pawn(int a, int b, string t) : base(a, b, t)
        {
            if (this.team == "black")
                this.asset = 11;
            else if (this.team == "white")
                this.asset = 5;
        }
        override public List<Position> allpossiblemoves(ChessPiece[,] matrix)
        {
            int x = this.pos.x;
            int y = this.pos.y;
            List<Position> list = new List<Position>();
            #region white possible moves        
            if (this.team == "white")
            {

                int NewYPos = y + 1;
                list.Add(new Position(x, NewYPos));
                if (firstMove)
                {
                    NewYPos = NewYPos + 1;
                    list.Add(new Position(x, NewYPos));

                }
                if (x < 7 && matrix[x + 1, y + 1] != null)
                {
                    if (matrix[x + 1, y + 1].team == "black")
                    {
                        int NewY = y + 1;
                        int NewX = x + 1;
                        list.Add(new Position(NewX, NewY));
                    }
                }
                if (x > 0 && matrix[x - 1, y + 1] != null)
                {
                    if (matrix[x - 1, y + 1].team == "black")
                    {
                        int NewY = y + 1;
                        int NewX = x - 1;
                        list.Add(new Position(NewX, NewY));
                    }
                }

            }
#endregion
            if (this.team == "black")
            {
                int NewYPos = y - 1;
                list.Add(new Position(x, NewYPos));
                if (firstMove)
                {
                    NewYPos = NewYPos - 1;
                    list.Add(new Position(x, NewYPos));

                }

                if (x < 7 && matrix[x + 1, y - 1] != null)
                {
                    if (matrix[x + 1, y - 1].team == "black")
                    {
                        int NewY = y - 1;
                        int NewX = x + 1;
                        list.Add(new Position(NewX, NewY));
                    }
                }
                if (x > 0 && matrix[x - 1, y - 1] != null)
                {
                    if (matrix[x - 1, y - 1].team == "black")
                    {
                        int NewY = y - 1;
                        int NewX = x - 1;
                        list.Add(new Position(NewX, NewY));
                    }
                }
            }

            return list;
        }
    }
}
