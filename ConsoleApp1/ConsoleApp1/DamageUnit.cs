using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DamageUnit : Units
    {

        internal DamageUnit(int hp, bool ally) : base(hp, ally)
        {
            this._hp = hp;
            this.ally = ally;
        }

        internal void Damage()
        {
            List<Units> targetList = ally ? Program._enemyUnits : Program._allyUnits;

            Units target = null;
            foreach (Units u in targetList)
            {
                if (u != this)
                {
                    target = u;
                    break;
                }
            }

            if (target != null)
            {
                target.LoseHP(10); 
            }
            else
            {
                if (ally)
                {
                    Program.enemy.LoseHP(10);
                    Console.WriteLine($"{this} atacó la base enemiga causando 10 de daño.");
                }
                else
                {
                    Program.player.LoseHP(10);
                    Console.WriteLine($"{this} atacó la base del jugador causando 10 de daño.");
                }
            }
        }
    }
}
