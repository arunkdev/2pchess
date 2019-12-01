using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Pawn : ChessPiece
{
    bool firstMove = true;
    public Pawn(int a, int b, string t):base(a, b, t) 
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
        List <Position> list = new List<Position>();
        if(this.team=="white")
        {
            int NewYPos = y + 1;
            list.Add(new Position(x, NewYPos));
            if(firstMove)
            {
                NewYPos = NewYPos + 1;
                list.Add(new Position(x, NewYPos));

            }
            if (matrix[x+1,y+1]!=null)
            {
                if(matrix[x+1,y+1].team=="black")
                {
                    int NewY = y + 1;
                    int NewX = x + 1;
                    list.Add(new Position(NewX, NewY));
                }
            }
            if (matrix[x - 1, y + 1] != null)
            {
                if (matrix[x - 1, y + 1].team == "black")
                {
                    int NewY = y + 1;
                    int NewX = x - 1;
                    list.Add(new Position(NewX, NewY));
                }
            }

        }
        if (this.team == "black")
        {
            int NewYPos = y - 1;
            list.Add(new Position(x, NewYPos));
            if (firstMove)
            {
                NewYPos = NewYPos - 1;
                list.Add(new Position(x, NewYPos));

            }
            
            if (matrix[x + 1, y - 1] != null)
            {
                if (matrix[x + 1, y - 1].team == "black")
                {
                    int NewY = y - 1;
                    int NewX = x + 1;
                    list.Add(new Position(NewX, NewY));
                }
            }
            if (matrix[x - 1, y - 1] != null)
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
