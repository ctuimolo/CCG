using System;
using System.Collections.Generic;
using System.Text;

namespace MGCCG.CCG
{
    public interface IDamageable
    {
        void ReceiveAttack(CombatCard attacker);
    }
}
