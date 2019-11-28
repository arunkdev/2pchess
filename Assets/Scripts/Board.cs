using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Board : MonoBehaviour
{
    public ChessPiece[,] matrix;

    Board()
    {
        matrix = new ChessPiece[8, 8]
        {
            { new ChessPiece(0,0,"white"), new ChessPiece(0,1,"white"), null, null, null, null, new ChessPiece(0,6,"black"), new ChessPiece(0,7,"black") },
            { new ChessPiece(1,0,"white"), new ChessPiece(1,1,"white"), null, null, null, null, new ChessPiece(1,6,"black"), new ChessPiece(1,7,"black") },
            { new ChessPiece(2,0,"white"), new ChessPiece(2,1,"white"), null, null, null, null, new ChessPiece(2,6,"black"), new ChessPiece(2,7,"black") },
            { new ChessPiece(3,0,"white"), new ChessPiece(3,1,"white"), null, null, null, null, new ChessPiece(3,6,"black"), new ChessPiece(3,7,"black") },
            { new ChessPiece(4,0,"white"), new ChessPiece(4,1,"white"), null, null, null, null, new ChessPiece(4,6,"black"), new ChessPiece(4,7,"black") },
            { new ChessPiece(5,0,"white"), new ChessPiece(5,1,"white"), null, null, null, null, new ChessPiece(5,6,"black"), new ChessPiece(5,7,"black") },
            { new ChessPiece(6,0,"white"), new ChessPiece(6,1,"white"), null, null, null, null, new ChessPiece(6,6,"black"), new ChessPiece(6,7,"black") },
            { new ChessPiece(7,0,"white"), new ChessPiece(7,1,"white"), null, null, null, null, new ChessPiece(7,6,"black"), new ChessPiece(7,7,"black") },
        };
    }
}
