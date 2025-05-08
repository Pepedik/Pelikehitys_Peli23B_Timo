using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robootti.Timo
{
    internal class Käynnistä : RobottiKäsky
    {
        public void Suorita(Robotti R)
        {
            if (R.OnKäynnissä == false)
            {
                R.OnKäynnissä = true;
            }
        }
    }
}
