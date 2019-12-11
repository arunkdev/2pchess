using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace tw0pchess
{

    public class King : ChessPiece
    {
        bool firstMove = true;
        public King(int a, int b, string t) : base(a, b, t)
        {
            if (this.team == "black")
                this.asset = 6;
            else if (this.team == "white")
                this.asset = 0;
        }
        override public List<Position> allpossiblemoves(ChessPiece[,] matrix)
        {
            int x = this.pos.x;
            int y = this.pos.y;


            List<Position> list = new List<Position>();
            if (x + 1 <= 7)
            {
                if (matrix[x + 1, y] == null) { list.Add(new Position(x + 1, y)); }
                else if ((matrix[x + 1, y] != null) && this.team != matrix[x + 1, y].team) { list.Add(new Position(x + 1, y)); }
            }
            if (y + 1 <= 7)
            {
                if (matrix[x,y+1] == null) { list.Add(new Position(x, y + 1)); }
                else if ((matrix[x, y + 1] != null) && this.team != matrix[x, y + 1].team) { list.Add(new Position(x, y + 1)); }
            }
            if (x - 1 >=0)
            {
                if (matrix[x -1, y] == null) { list.Add(new Position(x - 1, y)); }
                else if ((matrix[x - 1, y] != null) && this.team != matrix[x - 1, y].team) { list.Add(new Position(x - 1, y)); }
            }
            if (y - 1 >= 0)
            {
                if (matrix[x,y-1] == null) { list.Add(new Position(x, y - 1)); }
                else if ((matrix[x, y - 1] != null) && this.team != matrix[x, y - 1].team) { list.Add(new Position(x, y - 1)); }
            }
            if (x + 1 <= 7 && y +1 <= 7)
            {
                if (matrix[x + 1, y + 1] == null) { list.Add(new Position(x + 1, y + 1)); }
                else if ((matrix[x + 1, y + 1] != null) && this.team != matrix[x + 1, y + 1].team) { list.Add(new Position(x + 1, y + 1)); }
            }
            if (x - 1 >= 0 && y + 1 <= 7)
            {
                if (matrix[x - 1, y + 1] == null) { list.Add(new Position(x - 1, y + 1)); }
                else if ((matrix[x - 1, y + 1] != null) && this.team != matrix[x - 1, y + 1].team) { list.Add(new Position(x - 1, y + 1)); }
            }
            if (x - 1 >= 0 && y - 1 >= 0)
            {
                if (matrix[x - 1, y - 1] == null) { list.Add(new Position(x - 1, y - 1)); }
                else if ((matrix[x - 1, y - 1] != null) && this.team != matrix[x - 1, y - 1].team) { list.Add(new Position(x - 1, y - 1)); }
            }
            if (x + 1 <= 7 && y - 1 >= 0)
            {
                if (matrix[x + 1, y - 1] == null) { list.Add(new Position(x + 1, y - 1)); }
                else if ((matrix[x + 1, y - 1] != null) && this.team != matrix[x + 1, y - 1].team) { list.Add(new Position(x + 1, y - 1)); }
            }
            return list;
        }
    }
}
