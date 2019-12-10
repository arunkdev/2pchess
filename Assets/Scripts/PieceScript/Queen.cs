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
        { return new List<Position>(); }
    }
}