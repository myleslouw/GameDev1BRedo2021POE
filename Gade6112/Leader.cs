using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade6112
{
    class Leader : Enemy
    {
        private Tile Target;


        public Leader(int _yPos, int _xPos) : base(_yPos, _xPos, 2, 20, 20, "L")
        {
            X = _xPos;
            Y = _yPos;
            MaxHP = 20;
            HP = 20;
            Damage = 2;

        }

        public override movement ReturnMovement(movement move = movement.noMvm)
        {
            return base.ReturnMovement(move);
        }
    }
}
