using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace tw0pchess
{

    public class ChessPiece
    {
        public Position pos;
        virtual public List<Position> allpossiblemoves(ChessPiece[,] matrix) { return null; }
        public string team;
        public piececolor myColor;
        public int asset = 0;


        public ChessPiece(int x, int y,piececolor Color)
        {
            this.pos = new Position(x, y);
            //this.team = team;
            this.myColor = Color;

        }
        public ChessPiece(int x, int y, string team)
        {
            this.pos = new Position(x, y);
            this.team = team;
            

        }

    }
}
