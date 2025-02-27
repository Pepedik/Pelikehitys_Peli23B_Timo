using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Seikkailijanreppu
{
    class Arrow : Items
    {
        public Arrow(string Feather, string Tip) : base(0.1f, (2))
        {
            this.FeatherType = Feather;
            this.TipType = Tip;
        }
        public string FeatherType;
        public string TipType;
        public override string ToString()
        {
            return "Arrow with this feather " + this.FeatherType + " and this tip type " + this.TipType;
        }
    }
}
