using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Bases : life
    {
        internal int _resource;
        internal int _hp;

        internal Bases(int resource, int hp)
        {
            this._resource = resource;
            this._hp = hp;
        }

        internal void RecolectResources()
        {
            _resource += 10;
        }

         public void LoseHP(int _loseHP)
         {
            _hp -= _loseHP;

            if (_hp <= 0)
            {
                Console.WriteLine("End Game");
                Environment.Exit(0);
            }
         }
    } 
}
