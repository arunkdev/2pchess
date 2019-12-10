using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace tw0pchess
{

    public class Position
    {
        public int x;
        public int y;
        public Position(int a, int b)
        {
            this.x = a;
            this.y = b;
        }

        public override bool Equals(object obj)
        {
            var p = obj as Position;
            if (p == null)
                return false;
            return ( (this.x == p.x) && (this.y == p.y) );
        }

        public override int GetHashCode()
        {
            return ((x*8)+y);
        }
    }
}
