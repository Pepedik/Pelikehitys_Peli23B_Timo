using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seikkailijanreppu
{
    internal class Food : Items
    {
        public Food(float Fullness) : base(1.0f, 0.5f)
        {
            this.Fullness = Fullness;
        }
        public float Fullness;
        public override string ToString()
        {
            return "Food with fullness of " + this.Fullness;
        }
    }
}
