using System;
using System.Collections.Generic;
using System.Text;

namespace MGCCG.CCG.Cards
{
    class Lacertate : CombatCard
    {
        public Lacertate()
        {
            Name        = "Lacerate";
            EffectText  = "Cast a vision of ethereal blades.";
            FlavorText  = "(temp)";

            BaseAttack  = 3;
            BaseUses    = 2;
            BaseCost    = 1;

        }
    }
}
