using _25_SpaceShiipBattle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Star_Track_Battle
{
    class Program
    {
        private const int shieldStrength = 15;
        static void Main(string[] args)
        {

            int strength;
            bool gameover = false;

            SpaceShip[] spaceShip = new SpaceShip[6];
            spaceShip[0] = new Galaxy("NCC-1701-D", "Enterprise", shieldStrength);
            spaceShip[1] = new Galaxy("NCC-26517-A", "Excalibur", shieldStrength);
            spaceShip[2] = new DefiantClass("NCC-75633", "Defiant", shieldStrength);
            spaceShip[3] = new BattleCruiser("Vor'Nak", shieldStrength);
            spaceShip[4] = new BattleCruiser("K'Hecth", shieldStrength);
            spaceShip[5] = new BirdOfPrey("Toh'Koht", shieldStrength);

            Console.WriteLine("Let the battle begin! \n");

            while (!gameover)
            {

                Random random = new Random();
                int index = 0;

                for (int i = 0; i < 150000; i++)
                {
                    index =random.Next(spaceShip.Length);
                }

                SpaceShip fireShip = spaceShip[index];
                strength = fireShip.Fire();
                Console.WriteLine(fireShip);

                if (index <= 2)
                {
                    int kesIndex = random.Next(3, 6);
                    KlingonShip kesShip = (KlingonShip)spaceShip[kesIndex];
                    kesShip.Hit(strength);

                    Console.WriteLine("{0}: is HIT. Shield strength is {1}", kesShip.Name, kesShip.ShieldStrength);
                }
                else
                {
                    int ussIndex = random.Next(0, 3);
                    StarShip ussShip = (StarShip)spaceShip[ussIndex];
                    ussShip.Hit(strength);

                    Console.WriteLine("{0}: is HIT. Shield strength is {1}", ussShip.Name, ussShip.ShieldStrength);
                }

                Console.WriteLine("");
                for (int i = 0; i < spaceShip.Length; i++)
                {
                    if (spaceShip[i].ShieldStrength > 0)
                        Console.WriteLine(spaceShip[i].Name + " shield strength is " + spaceShip[i].ShieldStrength);
                    else
                        Console.WriteLine(spaceShip[i].Name + " has been destroyed!");


                    if (spaceShip[0].IsDestroyed && spaceShip[1].IsDestroyed && spaceShip[2].IsDestroyed)
                    {
                        Console.WriteLine("GAME OVER!!! KES WINS!");
                        gameover = true;
                        break;
                    }
                    if (spaceShip[3].IsDestroyed && spaceShip[4].IsDestroyed && spaceShip[5].IsDestroyed)
                    {
                        Console.WriteLine("GAME OVER!!! USS WINS!");
                        gameover = true;
                        break;
                    }
                }

                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
