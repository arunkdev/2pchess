using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace tw0pchess
{

    public class Rook : ChessPiece
    {
        bool firstMove = true;
        public Rook(int a, int b, string t) : base(a, b, t)
        {
            if (this.team == "black")
                this.asset = 8;
            else if (this.team == "white")
                this.asset = 2;
        }
        override public List<Position> allpossiblemoves(ChessPiece[,] matrix)
        { return null; }
    }
}
