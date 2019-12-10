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
        { return new List<Position>(); }
    }
}