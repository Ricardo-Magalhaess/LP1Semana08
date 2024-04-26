using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager4
{
    public class CompareByName :IComparer<Player>
    {
        private bool order;
        public CompareByName(bool order = true)
        {
            this.order = order;
        }

    }
}