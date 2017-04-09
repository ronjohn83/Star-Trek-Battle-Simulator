using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_SpaceShiipBattle
{
    public abstract class StarShip : SpaceShip
    {

        public const string prefix = "USS ";
        public StarShip(string registry, string name, int shieldStrength) : base(prefix + name, shieldStrength)
        {
            Registry = registry;
        }

        public string Prefix { get { return prefix; } }
        public string Registry { get; }

        public abstract override int Fire();

    }
}
