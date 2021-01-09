using System;
using System.Collections.Generic;
using System.Text;

namespace NezTest_OpenGL.CCG
{
    public interface IDamageable
    {
        public void ReceiveAttack(CombatCard attacker);
    }
}
