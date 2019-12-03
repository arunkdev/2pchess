using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace tw0pchess
{

    public class Bishop : ChessPiece
    {
        bool firstMove = true;
        public Bishop(int a, int b, string t) : base(a, b, t)
        {
            if (this.team == "black")
                this.asset = 9;
            else if (this.team == "white")
                this.asset = 3;
        }
        override public List<Position> allpossiblemoves(ChessPiece[,] matrix)
        { return null; }
    }
}