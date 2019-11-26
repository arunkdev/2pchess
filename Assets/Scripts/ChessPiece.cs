using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector2;

public abstract class ChessPiece : MonoBehaviour
{
    private vector2<int> pos;
    public List<vector2<int>> allpossiblemoves();

    ChessPiece()
    {

    }


}
