using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChessPiece : MonoBehaviour
{
    public Position pos;
    virtual public List<Position> allpossiblemoves(ChessPiece[,] matrix) { return null; }
    public string team;

    public ChessPiece(int x, int y, string team)
    {
        this.pos = new Position(x, y);
        this.team = team; 
    }


}

