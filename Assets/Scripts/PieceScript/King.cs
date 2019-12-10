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
        { return new List<Position>(); }
    }
}
