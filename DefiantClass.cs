using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_SpaceShiipBattle
{
    class DefiantClass : StarShip
    {
        private int phasers;
        private int pTorpedoes;
        private int qTorpedoes;
        private const int PHASER_STRENTH = 1;
        private const int pTORPEDO_STRENTH = 2;
        private const int qTORPEDO_STRENTH = 4;

        public DefiantClass(string registry, string name, int shieldStrength) : base(registry, name, shieldStrength)
        {
            pTorpedoes = 1;
            qTorpedoes = 1;
        }

        public override int Fire()
        {
            Random random = new Random();
            int randomWeapon = random.Next(300);

            if (randomWeapon < 100)
            {
                Weapon = "Phaser";
                return PHASER_STRENTH;
            }
            else if (randomWeapon < 200)
            {
                if (pTorpedoes <= 0)
                {
                    pTorpedoes = 1;
                    Weapon = "Photon torpedo";
                    return 0;
                }
                else
                {
                    Weapon = "Photon torpedo";
                    pTorpedoes -= pTORPEDO_STRENTH;
                    return 2;
                }
            }
            else 
            {
                if (qTorpedoes <= 0)
                {
                    qTorpedoes = 1;
                    Weapon = "quantum torpedo";
                    return 0;
                }
                else
                {
                    Weapon = "quantum torpedo";
                    qTorpedoes -= 1;
                    return qTORPEDO_STRENTH;
                }
            }
        }

        //public override string ToString()
        //{
        //    return base.ToString() + Name + " fires: " + Weapon;
        //}
    }
}
