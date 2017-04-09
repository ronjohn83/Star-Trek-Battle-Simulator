using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_SpaceShiipBattle
{
    class Galaxy : StarShip
    {
        private int pTorpedoes;
        private int phasers;
        private const int PHASER_STRENTH = 1;
        private const int TORPEDO_STRENTH = 2;
        
        public Galaxy(string registry, string name, int shieldStrength) : base(registry, name, shieldStrength)
        {
            pTorpedoes = 10;
        }

        public override int Fire()
        {
            Random random = new Random();
            int randomWeapon = random.Next(200);

            if (randomWeapon < 100)
            {
                Weapon = "Phaser";
                return PHASER_STRENTH;
            }
            else
            {
                if (pTorpedoes <= 0)
                {
                    pTorpedoes = 10;
                    Weapon = "Photon torpedo";
                    return 0;
                }
                else
                {
                    Weapon = "Photon torpedo";
                    pTorpedoes -= 1;
                    return TORPEDO_STRENTH;
                }
            }
        }

        //public override string ToString()
        //{
        //    return base.ToString() + Name + " fires: " + Weapon;
        //}
    }
}
