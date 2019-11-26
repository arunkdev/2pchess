using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public ChessPiece[,] matrix;

    Board()
    {
        matrix = new ChessPiece[8, 8]
        {
            { new ChessPiece(0,0,"white"), new ChessPiece(0,1,"white"), new ChessPiece(0,2,"white"), new ChessPiece(0,3,"white"), new ChessPiece(0,4,"white"), new ChessPiece(0,5,"white"), new ChessPiece(0,6,"white"), new ChessPiece(0,7,"white") },
            { new ChessPiece(1,0,"white"), new ChessPiece(1,1,"white"), new ChessPiece(1,2,"white"), new ChessPiece(1,3,"white"), new ChessPiece(1,4,"white"), new ChessPiece(1,5,"white"), new ChessPiece(1,6,"white"), new ChessPiece(1,7,"white") },
            { null, null, null, null, null, null, null, null },
            { null, null, null, null, null, null, null, null },
            { null, null, null, null, null, null, null, null },
            { null, null, null, null, null, null, null, null },
            { new ChessPiece(6,0,"black"), new ChessPiece(6,1,"black"), new ChessPiece(6,2,"black"), new ChessPiece(6,3,"black"), new ChessPiece(6,4,"black"), new ChessPiece(6,5,"black"), new ChessPiece(6,6,"black"), new ChessPiece(6,7,"black") },
            { new ChessPiece(7,0,"black"), new ChessPiece(7,1,"black"), new ChessPiece(7,2,"black"), new ChessPiece(7,3,"black"), new ChessPiece(7,4,"black"), new ChessPiece(7,5,"black"), new ChessPiece(7,6,"black"), new ChessPiece(7,7,"black") }
        };
    }
}
