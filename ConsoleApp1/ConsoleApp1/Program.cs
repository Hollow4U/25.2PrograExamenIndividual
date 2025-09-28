using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        internal static Bases player = new Bases(0, 100);
        internal static DamageUnit _damageUnit = new DamageUnit(20);
        internal static DamageUnit _damageUnit2 = new DamageUnit(10);

        internal static List<Units> units = new List<Units>();
       
        static void Main(string[] args)
        {
            units.Add(_damageUnit);
            units.Add(_damageUnit2);
            ((DamageUnit)units[0]).Damage();
        }
    }
}
