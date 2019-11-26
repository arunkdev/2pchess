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
            { new ChessPiece(), new ChessPiece(), new ChessPiece(), new ChessPiece(), new ChessPiece(), new ChessPiece(), new ChessPiece(), new ChessPiece() },
            { new ChessPiece(), new ChessPiece(), new ChessPiece(), new ChessPiece(), new ChessPiece(), new ChessPiece(), new ChessPiece(), new ChessPiece() },
            { null, null, null, null, null, null, null, null },
            { null, null, null, null, null, null, null, null },
            { null, null, null, null, null, null, null, null },
            { null, null, null, null, null, null, null, null },
            { new ChessPiece(), new ChessPiece(), new ChessPiece(), new ChessPiece(), new ChessPiece(), new ChessPiece(), new ChessPiece(), new ChessPiece() },
            { new ChessPiece(), new ChessPiece(), new ChessPiece(), new ChessPiece(), new ChessPiece(), new ChessPiece(), new ChessPiece(), new ChessPiece() }
        };
    }
}
