using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace tw0pchess
{

    public class Knight : ChessPiece
    {
        bool firstMove = true;
        public Knight(int a, int b, string t) : base(a, b, t)
        {
            if (this.team == "black")
                this.asset = 10;
            else if (this.team == "white")
                this.asset = 4;
        }
        override public List<Position> allpossiblemoves(ChessPiece[,] matrix)
        {
            int x = this.pos.x;
            int y = this.pos.y;


            List<Position> list = new List<Position>();
            if (x + 2 <= 7 && y+1<=7)
            {
                if (matrix[x + 2, y+1] == null) { list.Add(new Position(x + 2, y + 1)); }
                else if ((matrix[x + 2, y + 1] != null) && this.team != matrix[x + 2, y + 1].team) { list.Add(new Position(x + 2, y + 1)); }
            }
            if (y + 2 <= 7 && x + 1 <= 7)
            {
                if (matrix[x + 1, y + 2] == null) { list.Add(new Position(x + 1, y + 2)); }
                else if ((matrix[x + 1, y + 2] != null) && this.team != matrix[x + 1, y + 2].team) { list.Add(new Position(x + 1, y + 2)); }
            }
            if (x - 1 >= 0 && y + 2 <= 7)
            {
                if (matrix[x - 1, y + 2] == null) { list.Add(new Position(x - 1, y + 2)); }
                else if ((matrix[x - 1, y + 2] != null) && this.team != matrix[x - 1, y + 2].team) { list.Add(new Position(x - 1, y + 2)); }
            }
            if (x - 2 >= 0 && y + 1 <= 7 )
            {
                if (matrix[x - 2, y + 1] == null) { list.Add(new Position(x - 2, y + 1)); }
                else if ((matrix[x - 2, y + 1] != null) && this.team != matrix[x - 2, y + 1].team) { list.Add(new Position(x - 2, y + 1)); }
            }
            if (x - 2 >= 0 && y - 1 >= 0)
            {
                if (matrix[x - 2, y - 1] == null) { list.Add(new Position(x - 2, y - 1)); }
                else if ((matrix[x - 2, y - 1] != null) && this.team != matrix[x - 2, y - 1].team) { list.Add(new Position(x - 2, y - 1)); }
            }
            if (x - 1 >= 0 && y - 2 >= 0 )
            {
                if (matrix[x - 1, y - 2] == null) { list.Add(new Position(x - 1, y - 2)); }
                else if ((matrix[x - 1, y - 2] != null) && this.team != matrix[x - 1, y - 2].team) { list.Add(new Position(x - 1, y - 2)); }
            }
            if (x + 1 <= 7 && y - 2 >= 0)
            {
                if (matrix[x + 1, y - 2] == null) { list.Add(new Position(x + 1, y - 2)); }
                else if ((matrix[x + 1, y - 2] != null) && this.team != matrix[x + 1, y - 2].team) { list.Add(new Position(x + 1, y - 2)); }
            }
            if (x + 2 <= 7 && y - 1 >= 0)
            {
                if (matrix[x + 2, y - 1] == null) { list.Add(new Position(x + 2, y - 1)); }
                else if ((matrix[x + 2, y - 1] != null) && this.team != matrix[x + 2, y - 1].team) { list.Add(new Position(x + 2, y - 1)); }
            }
            return list;
        }
    }
}