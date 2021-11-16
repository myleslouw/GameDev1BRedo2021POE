using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade6112
{
    [Serializable]
    class Shop
    {
        private Weapon[] weaponArray;    //3 slots for weapons
        Random rndm;
        Character buyer;

        public Shop(Character _buyer)
        {

            buyer = _buyer;
            weaponArray = new Weapon[2];
            rndm = new Random();

            for (int i = 0; i < weaponArray.Length; i++)
            {
                weaponArray[i] = RandomWeapon();    //puts a random weapon in each slot
            }
        }

        private Weapon RandomWeapon()
        {
            int weaponNumber = rndm.Next(0,4);  //4 types of weapons

            switch (weaponNumber)
            {

                case 0:   //dagger

                    return new MeleeWeapon(0,0, "-", MeleeWeapon.Types.Dagger);  //the weapons internal x and y doesnt matter so it will be 0

                case 1:   //longsword

                    return new MeleeWeapon(0, 0, "/", MeleeWeapon.Types.Longsword);  //the weapons internal x and y doesnt matter so it will be 

                case 2:   //Rifle

                    return new RangedWeapon(0, 0, "^", RangedWeapon.Types.Longbow);  //the weapons internal x and y doesnt matter so it will be 0

                case 3:  //LongBow

                    return new RangedWeapon(0, 0, "*", RangedWeapon.Types.Rifle);  //the weapons internal x and y doesnt matter so it will be 
                
            }
            return null;
        }

        public bool CanBuy(int num)
        {
            return false;
        }

        public void Buy(int num)
        {

        }

        public string DisplayWeapon(int num)
        {
            return "Buy " + " ";
        }
    }
}
