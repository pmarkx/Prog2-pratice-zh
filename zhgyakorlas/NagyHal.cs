using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zhgyakorlas
{
    class NagyHal : Hal
    {
        public NagyHal(double tomeg) : base(tomeg,false)
        {

        }
        public override bool Kifog()
        {
            int help = myrandom.r.Next(0, 2);
            if (help==1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
