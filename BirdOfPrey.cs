using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_SpaceShiipBattle
{
    class BirdOfPrey : KlingonShip
    {
        private int pTorpedoes;
        private int disruptors;
        const int TORPEDO_STRENGTH = 2;
        const int DISRUPTOR_STRENGTH = 1;


        public BirdOfPrey(string name, int shieldStrength) : base(name, shieldStrength)
        {
            pTorpedoes = 3;
        }

        public override int Fire()
        {
            Random random = new Random();
            int randomWeapon = random.Next(200);

            if (randomWeapon < 100)
            {
                Weapon = "Disruptor";
                return DISRUPTOR_STRENGTH;
            }
            else
            {
                if (pTorpedoes <= 0)
                {
                    pTorpedoes = 3;
                    return 0;
                }
                else
                {
                    Weapon = "Photon torpedo";
                    pTorpedoes -= 1;
                    return TORPEDO_STRENGTH;
                }
            }
        }

        //public override string ToString()
        //{
        //    return base.ToString() + Name + " fires: " + Weapon;
        //}
    }
}
