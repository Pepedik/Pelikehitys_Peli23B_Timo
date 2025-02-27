using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Seikkailijanreppu
{
    class Sword : Items
    {
        public Sword(int Damage) : base(3.0f, (4))
        {
            this.Damage = Damage;
        }
        public int Damage;
    }
}
