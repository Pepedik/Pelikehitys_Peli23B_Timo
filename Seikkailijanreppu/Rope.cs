using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Seikkailijanreppu
{
    class Rope : Items
    {
        public Rope(float durability) : base(0.5f, (1))
        {
            this.durability = durability;
        }
        public float durability;
    }
}
