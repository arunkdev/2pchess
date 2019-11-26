using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector2;

public abstract class ChessPiece : MonoBehaviour
{
    private vector2<int> pos;
    virtual public List<vector2<int>> allpossiblemoves(ChessPiece[,] matrix);
    public string team;

    ChessPiece(int x, int y, string team)
    {
        this.pos = new vector2<int>(x, y);
        this.team = team; 
    }


}
