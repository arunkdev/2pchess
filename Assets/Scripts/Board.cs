using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace tw0pchess

{
    public class Board
    {
        public ChessPiece[,] matrix;

        public Board()
        {
            matrix = new ChessPiece[8, 8]
            {
            { new Rook  (0,0,"white"), new Pawn(0,1,"white"), null, null, null, null, new Pawn(0,6,"black"), new Rook  (0,7,"black") },
            { new Knight(1,0,"white"), new Pawn(1,1,"white"), null, null, null, null, new Pawn(1,6,"black"), new Knight(1,7,"black") },
            { new Bishop(2,0,"white"), new Pawn(2,1,"white"), null, null, null, null, new Pawn(2,6,"black"), new Bishop(2,7,"black") },
            { new Queen (3,0,"white"), new Pawn(3,1,"white"), null, null, null, null, new Pawn(3,6,"black"), new Queen (3,7,"black") },
            { new King  (4,0,"white"), new Pawn(4,1,"white"), null, null, null, null, new Pawn(4,6,"black"), new King  (4,7,"black") },
            { new Bishop(5,0,"white"), new Pawn(5,1,"white"), null, null, null, null, new Pawn(5,6,"black"), new Bishop(5,7,"black") },
            { new Knight(6,0,"white"), new Pawn(6,1,"white"), null, null, null, null, new Pawn(6,6,"black"), new Knight(6,7,"black") },
            { new Rook  (7,0,"white"), new Pawn(7,1,"white"), null, null, null, null, new Pawn(7,6,"black"), new Rook  (7,7,"black") },
            };
        }
        public List<Position> mouseClick(int x, int y)
        {
            ChessPiece chesspiece = this.matrix[x, y];
            List<Position> possibleList = new List<Position>();
            if (chesspiece != null)
            {
                possibleList = chesspiece.allpossiblemoves(this.matrix);
                return possibleList;
            }
            return possibleList;
        }
    }
}