using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seikkailijanreppu
{
    internal class water : Items
    {
        public water(float hydration) : base(1.5f, (2))
        {
            this.hydration = hydration;
        }
        public float hydration;

        public override string ToString()
        {
            return "Waters hydration of this hydration " + this.hydration;
        }
    }
}
