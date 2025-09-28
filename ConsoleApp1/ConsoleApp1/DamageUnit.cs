using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DamageUnit : Units
    {

        internal DamageUnit(int hp) : base(hp)
        {
            this._hp = hp;
        }

        internal void Damage()
        {
            Units target = null;
            foreach (Units u in Program.units)
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
                Program.player.LoseHP(10);
            }
        }
    }
}
