using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    internal interface IWalkAway // Naming convention is to start interfaces with an "I"
    {
        void WalkAway(Player player);
    }
}
