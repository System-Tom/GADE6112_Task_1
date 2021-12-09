using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunter
{
    abstract class Tile
    {
        protected int _x;
        protected int _y;

        public int X
        {
            get
            {
                return _x;
            }
            protected set
            {
                _x = value;
            }
        }
        public int Y
        {
            get
            {
                return _y;
            }
            protected set
            {
                _y = value;
            }
        }

        public enum TileType
        {
            Hero,
            Enemy,
            Gold,
            Weapon
        }

        protected Tile(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
