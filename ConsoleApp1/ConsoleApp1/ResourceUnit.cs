using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ResourceUnit : Units
    {

        internal ResourceUnit(int hp, bool ally) : base(hp, ally)
        {
            this._hp = hp;
            this.ally = ally;
        }

        internal void Generate()
        {
            Program.player.RecolectResources();
        }  
    }
}
