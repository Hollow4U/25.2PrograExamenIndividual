using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Units : life
    {
        protected int _hp;
        protected bool ally;

        internal Units(int hp, bool ally)
        {
            this._hp = hp;
            this.ally = ally;
        }

        public void LoseHP(int _loseHP)
        {
            _hp -= _loseHP;

            if (_hp <= 0 && ally == true)
            {
                Console.WriteLine("Guerrero derrotado");
                Program._allyUnits.Remove(this);
            }
            else if (_hp <= 0 && ally ==false)
            {
                Console.WriteLine("Enemigo derrotado");
                Program._enemyUnits.Remove(this);
            }
        }
    }
}
