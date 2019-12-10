using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace tw0pchess
{

    public class Rook : ChessPiece
    {
        public Rook(int a, int b, string t) : base(a, b, t)
        {
            if (this.team == "black")
                this.asset = 8;
            else if (this.team == "white")
                this.asset = 2;
        }
        override public List<Position> allpossiblemoves(ChessPiece[,] matrix)
        {
            int x = this.pos.x;
            int y = this.pos.y;
           
           
            List<Position> list = new List<Position>();
            bool canMoveUp = true;
            bool canMoveDown = true;
            bool canMoveRight = true;
            bool canMoveLeft = true;
            for (int a = 1;a <= 7; a++)
            {
                if((y + a <= 7) && canMoveUp)
                {
                    Position pos = new Position(x, y+a);
                    if (matrix[pos.x, pos.y] == null) { list.Add(pos); }
                    else if (matrix[pos.x, pos.y].team == this.team){ canMoveUp = false; }
                    else if (matrix[pos.x, pos.y].team != this.team) { list.Add(pos); canMoveUp = false; }
                }
                if((y-a>=0) && canMoveDown)
                {
                    Position pos = new Position(x, y - a);
                    if (matrix[pos.x, pos.y] == null) { list.Add(pos); }
                    else if (matrix[pos.x, pos.y].team == this.team) { canMoveDown = false; }
                    else if (matrix[pos.x, pos.y].team != this.team) { list.Add(pos); canMoveDown = false; }
                }
                if ((x + a <= 7) && canMoveRight)
                {
                    Position pos = new Position(x+a, y);
                    if (matrix[pos.x, pos.y] == null) { list.Add(pos); }
                    else if (matrix[pos.x, pos.y].team == this.team) { canMoveRight = false; }
                    else if (matrix[pos.x, pos.y].team != this.team) { list.Add(pos); canMoveRight = false; }
                }
                if ((x - a >= 0) && canMoveLeft)
                {
                    Position pos = new Position(x-a, y);
                    if (matrix[pos.x, pos.y] == null) { list.Add(pos); }
                    else if (matrix[pos.x, pos.y].team == this.team) { canMoveLeft = false; }
                    else if (matrix[pos.x, pos.y].team != this.team) { list.Add(pos); canMoveLeft = false; }
                }
            }
            return list;
        }
        
    }
}
