using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_SpaceShiipBattle
{
    abstract class KlingonShip : SpaceShip
    {
        public const string prefix = "KES ";

        public KlingonShip(string name, int shieldStrength) : base(prefix + name, shieldStrength)
        {
            
        }

        public string Prefix { get { return prefix; } }

        public abstract override int Fire();
    }
}
