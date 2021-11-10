using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade6112
{
    [Serializable]
    abstract class Character : Tile
    {
        protected int hp;
        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }
        protected int maxHp;
        public int MaxHP
        {
            get { return maxHp; }
            set { maxHp = value; }
        }
        protected int damage;
        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }
        
        protected Tile[] characterVision;

        public Tile[] CharacterVision
        {
            get { return characterVision; }
            set { characterVision = value; }
        }

        public enum movement {noMvm, Up, Down, Left, Right }
        string symbol;

        private int goldCount;

        public int GoldCount
        {
            get { return goldCount; }
            set { goldCount = value; }
        }
        private Gold currentGold;




        public Character(int _yPos, int _xPos, string _symbol) : base (_yPos, _xPos, _symbol)
        {
            X = _xPos;
            Y = _yPos;
            symbol = _symbol;
            CharacterVision = new Tile[4];   //creates an array with 4 elements for the surrounding positions

        }

        public virtual void Attack(Character target)
        {
            target.hp -= damage;
        }

        public bool isDead()
        {
            if (this.hp <= 0)  //if the health is 0 or below it will return true to show that it must be deleted
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool CheckRange(Character target)
        {
            

            return false;
        }

        private int DistanceTo(Character target)
        {

          
            return 0;
        }

        public void Move(movement move)  //cahnges internal X and Y values of the Tile
        {
            switch (move)  //changes the characters vales (must still change the position in the array)
            {
                case movement.noMvm:
                    break;
                case movement.Up:
                    Y--;
                    break;
                case movement.Down:
                    Y++;
                    break;
                case movement.Left:
                    x--;
                    break;
                case movement.Right:
                    x++;
                    break;
                default:
                    break;
            }

           

        }

        public abstract movement ReturnMovement(movement move = 0);

        public abstract override string ToString();

        public void Pickup(Item i)
        {
            if (i is Gold)   //if the item is of type gold it will be picked up and add
            {
                currentGold = (Gold)i;  //stored in a gold variable to access its gold amount
                goldCount += currentGold.GoldAmount; //adds the amount of gold to the characters gold Purse
            }
        }

    }
}
