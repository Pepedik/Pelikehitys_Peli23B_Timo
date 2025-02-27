using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Seikkailijanreppu
{
    class Bow : Items
    {
        public Bow(int Damage) : base(1.0f, (5))
        {
            this.Damage = Damage;
        }
        public int Damage;
        public float BowBase;
        public float BowString;

        public override string ToString()
        {
            return "Bow with this damage " + this.Damage;
        }
    }

}
