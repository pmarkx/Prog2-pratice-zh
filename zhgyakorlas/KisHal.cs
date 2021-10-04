using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zhgyakorlas
{
    class KisHal : Hal
    {
        public bool aranyhale { get; }
        public KisHal(double tomeg, bool szalkase,bool aranyhale=false) : base(tomeg, szalkase)
        {
            this.aranyhale = aranyhale;
        }
    }
}
