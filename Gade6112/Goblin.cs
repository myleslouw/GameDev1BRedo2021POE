using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade6112
{
    [Serializable]
    class Goblin : Enemy
    {
        Random rndm; //used for random generator
        int rndmEnum; // used for random number for enum

        public Goblin(int _yPos, int _xPos) : base (_yPos, _xPos, 1, 10,10,"G")
        {
            X = _xPos;
            Y = _yPos;
            MaxHP = 10;
            Damage = 1;
            Symbol = "G";

            rndm = new Random();
        }

        public override movement ReturnMovement(movement move)
        {
            //return a random direction
            //make sure direction is valid
            rndmEnum = rndm.Next(0, 4);

            //0 = up
            //1 = down
            //2 = left
            //3 = right
            switch (rndmEnum)
            {
                case 0:                                                //if rndm num is 0, that mean it will go up, so it checks if empty, if not it will rerun the method and try again
                    if (CharacterVision[0] is EmptyTile)
                    {
                        return movement.Up;
                    }
                    else
                    {
                        return ReturnMovement(movement.noMvm);
                    }
                    break;
                case 1:
                    if (CharacterVision[1] is EmptyTile)
                    {
                        return movement.Down;
                    }
                    else
                    {
                        return ReturnMovement(movement.noMvm);
                    }
                    break;
                case 2:
                    if (CharacterVision[2] is EmptyTile)
                    {
                        return movement.Left;
                    }
                    else
                    {
                        return ReturnMovement(movement.noMvm);
                    }
                    break;
                case 3:
                    if (CharacterVision[3] is EmptyTile)
                    {
                        return movement.Right;
                    }
                    else
                    {
                        return ReturnMovement(movement.noMvm);
                    }
                    break;
                default:
                    return movement.noMvm;
                    break;
            }

        }
        public override string ToString()
        {
            string enemyInfo;
            string className = "Goblin";
            enemyInfo = className + " at [" + X + ", " + Y + "] (Damage: " + Damage + ")(Health: " + this.hp + ")";
            return enemyInfo;
        }

    }
}
