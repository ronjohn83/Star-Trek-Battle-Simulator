using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_SpaceShiipBattle
{
    public abstract class SpaceShip
    {
        public SpaceShip(string name, int shieldStrength)
        {
            Name = name;
            ShieldStrength = shieldStrength;
            IsDestroyed = false;
        }

        public string Name { get; }
        public int ShieldStrength { get; set; }

        public string Weapon { get; set; }

        public bool IsDestroyed { get; set; }

        public void Hit(int strength)
        {
            

            if (ShieldStrength <= 0)
            {
                IsDestroyed = true;
            }
            else
                ShieldStrength -= strength;

        }

        public abstract int Fire();

        public override string ToString()
        {
            return Name + " fires: " + Weapon;
        }
    }
}
