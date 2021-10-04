using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zhgyakorlas
{
    abstract class Hal : IKifoghato
    {
        protected Hal(double tomeg, bool szalkase)
        {
            Tomeg = tomeg;
            this.szalkase = szalkase;
        }

        public double Tomeg { get; }
        public bool szalkase { get; }

        public virtual bool Kifog()
        {
            return true;
        }
    }
}
