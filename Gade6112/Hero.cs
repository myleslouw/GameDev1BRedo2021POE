using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade6112
{
    [Serializable]
    class Hero : Character
    {
        private Gold currentGoldObject;

        public Hero(int _xPos, int _yPos, int _maxHp) : base(_xPos, _yPos, "H")
        {
            X = _xPos;
            Y = _yPos;
            HP = _maxHp;
            MaxHP = _maxHp;
            Damage = 2;
            Symbol = "H";



        }

        public override void Attack(Character target)
        {
            target.HP -= this.damage;
            if (target.isDead())
            {
                
            }
        }
        public override movement ReturnMovement(movement move)
        {
           
            //depending on what direction the player asks, it will check if the vision array to see if its empty, if it is, it will mvoe, else it wont
            //it will also check for gold, if there is gold it will move there and pick up the gold
            switch (move)
            {
                case movement.noMvm:
                    break;
                case movement.Up:
                    if (CharacterVision[0] is Gold) //if it is gold it will move there but also pickup the gold
                    {
                        currentGoldObject = (Gold)characterVision[0];
                        Pickup(currentGoldObject);
                        return move;
                    }
                    else if (CharacterVision[0] is EmptyTile)  //if it is empty it will move there
                    {
                        return move;
                    }
                    else  //means it is not empty or gold and shouldnt be able to move there
                    {
                        return movement.noMvm;
                    }
                    break;
                case movement.Down:
                    if (CharacterVision[1] is Gold) //if it is gold it will move there but also pickup the gold
                    {
                        currentGoldObject = (Gold)characterVision[1];
                        Pickup(currentGoldObject);
                        return move;
                    }
                    else if (CharacterVision[1] is EmptyTile)
                    {
                        return move;
                    }
                    else
                    {
                        return movement.noMvm;
                    }
                    break;
                case movement.Left:
                    if (CharacterVision[2] is Gold) //if it is gold it will move there but also pickup the gold
                    {
                        currentGoldObject = (Gold)characterVision[2];
                        Pickup(currentGoldObject);
                        return move;
                    }
                    else if (CharacterVision[2] is EmptyTile)
                    {
                        return move;
                    }
                    else
                    {
                        return movement.noMvm;
                    }
                    break;
                case movement.Right:
                    if (CharacterVision[3] is Gold) //if it is gold it will move there but also pickup the gold
                    {
                        currentGoldObject = (Gold)characterVision[3];
                        Pickup(currentGoldObject);
                        return move;
                    }
                    else if (CharacterVision[3] is EmptyTile)
                    {
                        return move;
                    }
                    else
                    {
                        return movement.noMvm;
                    }
                    break;
                default:
                    break;
            }

            return Character.movement.noMvm;

        }

        public override string ToString()
        {
            string heroInfo;
            heroInfo = "Player Stats: \n HP: " + HP + " / " + MaxHP + "Current Weapon: " +currentWeapon + "\n Weapon Range: " + currentWeapon.Range + "\n Weapon Damage: " + currentWeapon.Damage + "\n [" + X + " , " + Y + "]. Gold = " + GoldCount;
            return heroInfo; ;
        }
    }
}
