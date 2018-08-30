using System.Collections.Generic;

namespace MonsterArena
{
    class Goblin : Monster
    {
        public Goblin(string name) : base(name)
        {
            AddBonusDexterity(25);
            AddBonusLuck(25);
            AddBonusStrength(25);
            AddBonusVitality(25);
        }

        public override int GetAttackIndex(List<MonsterData> monsters)
        {
            int index = monsters.FindIndex(m => m.level > 1);
            if (index >= 0)
            {
                return index;
            }
            else
            {
                return base.GetAttackIndex(monsters);
            }
        }
    }
}
