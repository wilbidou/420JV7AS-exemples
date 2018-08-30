using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterArena
{
    class AtlasWorldLifter : Monster
    {
        public AtlasWorldLifter(string name) : base(name)
        {
            AddBonusLuck(75);
            AddBonusVitality(25);
        }

    }
}
