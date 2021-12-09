using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunter
{
    class Character : Tile
    {
        protected int _hp;
        protected int _maxHp;
        protected int _damage;

        // North, South, East and West Tiles
        Tile[] VisibleTiles;

        public enum EMovement
        {
        NOMOVEMENT,
        UP,
        DOWN,
        LEFT,
        RIGHT
        }

        public int Hp
        {
            get
            {
                return _hp;
            }
            protected set
            {
                _hp = value;
            }
        }

        public int MaxHp
        {
            get
            {
                return _maxHp;
            }
            protected set
            {
                _maxHp = value;
            }
        }

        public int Damage
        {
            get
            {
                return _damage;
            }
            protected set
            {
                _damage = value;
            }
        }

        public Character(int x, int y,char Symbol) : base(x, y)
        {
            Hp = 5;
            Damage = 1;
        }

        public virtual void Attack(Character target)
        {
            target.Hp -= Damage;
        }

        public bool IsDead()
        {
            return (Hp < 1);
        }

        public virtual bool CheckRange(Character target)
        {
            return DistanceTo(target)<=1;
        }

        public virtual int DistanceTo(Character target)
        {
            return (int)MathF.Round(MathF.Abs(X - target.X) + MathF.Abs(Y - target.Y));
        }

        public void Move(EMovement move)
        {
            switch (move)
            {
                case EMovement.UP:
                    Y++;
                    break;
                case EMovement.DOWN:
                    Y--;
                    break;
                case EMovement.LEFT:
                    X--;
                    break;
                case EMovement.RIGHT:
                    X++;
                    break;
                default:
                    break;
            }

        }
    }
}
