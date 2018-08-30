using System.Collections.Generic;

namespace MonsterArena
{
    class Goblin : Monster
    {
        public Goblin(string name) : base(name)
        {
            AddBonusLuck(25);
            AddBonusStrength(60);
            AddBonusVitality(15);
        }
    }
}
