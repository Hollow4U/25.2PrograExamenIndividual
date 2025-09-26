using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Units : life
    {
        int _hp;

        internal Units(int hp)
        {
            this._hp = hp;
        }

        public void LoseHP(int _loseHP)
        {
            _hp -= _loseHP;

            if (-_hp <= 0)
            {
                Console.WriteLine("Eliminar de una lista de unidades");
            }
        }
    }
}
