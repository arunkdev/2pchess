using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace tw0pchess
{

    public class Queen : ChessPiece
    {
        bool firstMove = true;
        public Queen(int a, int b, string t) : base(a, b, t)
        {
            if (this.team == "black")
                this.asset = 7;
            else if (this.team == "white")
                this.asset = 1;
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
            bool canMoveUpRight = true;
            bool canMoveDownLeft = true;
            bool canMoveRightDown = true;
            bool canMoveLeftUp = true;
            for (int a = 1; a <= 7; a++)
            {
                if ((y + a <= 7) && canMoveUp)
                {
                    Position pos = new Position(x, y + a);
                    if (matrix[pos.x, pos.y] == null) { list.Add(pos); }
                    else if (matrix[pos.x, pos.y].team == this.team) { canMoveUp = false; }
                    else if (matrix[pos.x, pos.y].team != this.team) { list.Add(pos); canMoveUp = false; }
                }
                if ((y - a >= 0) && canMoveDown)
                {
                    Position pos = new Position(x, y - a);
                    if (matrix[pos.x, pos.y] == null) { list.Add(pos); }
                    else if (matrix[pos.x, pos.y].team == this.team) { canMoveDown = false; }
                    else if (matrix[pos.x, pos.y].team != this.team) { list.Add(pos); canMoveDown = false; }
                }
                if ((x + a <= 7) && canMoveRight)
                {
                    Position pos = new Position(x + a, y);
                    if (matrix[pos.x, pos.y] == null) { list.Add(pos); }
                    else if (matrix[pos.x, pos.y].team == this.team) { canMoveRight = false; }
                    else if (matrix[pos.x, pos.y].team != this.team) { list.Add(pos); canMoveRight = false; }
                }
                if ((x - a >= 0) && canMoveLeft)
                {
                    Position pos = new Position(x - a, y);
                    if (matrix[pos.x, pos.y] == null) { list.Add(pos); }
                    else if (matrix[pos.x, pos.y].team == this.team) { canMoveLeft = false; }
                    else if (matrix[pos.x, pos.y].team != this.team) { list.Add(pos); canMoveLeft = false; }
                }
                if ((y + a <= 7) && (x + a <= 7) && canMoveUpRight)
                {
                    Position pos = new Position(x + a, y + a);
                    if (matrix[pos.x, pos.y] == null) { list.Add(pos); }
                    else if (matrix[pos.x, pos.y].team == this.team) { canMoveUpRight = false; }
                    else if (matrix[pos.x, pos.y].team != this.team) { list.Add(pos); canMoveUpRight = false; }
                }
                if ((y - a >= 0) && (x - a >= 0) && canMoveDownLeft)
                {
                    Position pos = new Position(x - a, y - a);
                    if (matrix[pos.x, pos.y] == null) { list.Add(pos); }
                    else if (matrix[pos.x, pos.y].team == this.team) { canMoveDownLeft = false; }
                    else if (matrix[pos.x, pos.y].team != this.team) { list.Add(pos); canMoveDownLeft = false; }
                }
                if ((x + a <= 7) && (y - a >= 0) && canMoveRightDown)
                {
                    Position pos = new Position(x + a, y - a);
                    if (matrix[pos.x, pos.y] == null) { list.Add(pos); }
                    else if (matrix[pos.x, pos.y].team == this.team) { canMoveRightDown = false; }
                    else if (matrix[pos.x, pos.y].team != this.team) { list.Add(pos); canMoveRightDown = false; }
                }
                if ((x - a >= 0) && (y + a <= 7) && canMoveLeftUp)
                {
                    Position pos = new Position(x - a, y + a);
                    if (matrix[pos.x, pos.y] == null) { list.Add(pos); }
                    else if (matrix[pos.x, pos.y].team == this.team) { canMoveLeftUp = false; }
                    else if (matrix[pos.x, pos.y].team != this.team) { list.Add(pos); canMoveLeftUp = false; }
                }
            }
            return list;
        }
    }
}