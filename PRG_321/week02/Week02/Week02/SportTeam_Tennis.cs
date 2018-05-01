using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week02
{
    public class SportTeam_Tennis : SportTeam
    {
        public override String ShowClassName()
        {
            String content = "Tennis Team";
            return content;
        }
    }
}