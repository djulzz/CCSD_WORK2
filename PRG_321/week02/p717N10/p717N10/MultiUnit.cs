using System;
using System.Collections.Generic;
using System.Text;

namespace p717N10
{
    public class MultiUnit : Housing, IUnits
    {
        public override int NumberUnits()
        {
            return 9;
        }
    }
}
