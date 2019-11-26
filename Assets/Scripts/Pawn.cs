using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : ChessPiece
{
    bool firstMove = true;
    virtual public List<vector2<int>> allpossiblemoves(ChessPiece[,] matrix)
    {
        int x = this.pos.get(0);
        int y = this.pos.get(1);
        List <vector2<int>> list = new ArrayList<vector2<int>>();
        if(this.team=="white")
        {
            int NewYPos = y + 1;
            list.Add(new vector2<int>(x, NewYPos));
            if(firstMove)
            {
                NewYPos = NewYPos + 1;
                list.Add(new vector2<int>(x, NewYPos));

            }
         
        }
        if (this.team == "black")
        {
            int NewYPos = y - 1;
            list.Add(new vector2<int>(x, NewYPos));
            if (firstMove)
            {
                NewYPos = NewYPos - 1;
                list.Add(new vector2<int>(x, NewYPos));

            }

        }

    }
}
