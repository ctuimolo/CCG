using System;
using System.Collections.Generic;
using System.Text;

namespace NezTest_OpenGL.CCG
{
    public enum CardClass
    {
        Combat,
        Shadow,
    }

    public abstract class CombatCard : Card
    {
        public int BaseAttack   { get; protected set; }
        public int BaseUses     { get; protected set; }
        public int Uses         { get; protected set; }

        public virtual void Attack(IDamageable target)
        {
            target.ReceiveAttack(this);
        }

        public void ModifyBaseAttack(int arg)
        {
            BaseAttack += arg;
        }
        public void ModifyBaseUses(int arg)
        {
            BaseUses += arg;
        }
        public void OnUse()
        {
            Uses -= 1;
        }

        public override void Resolve()
        {
            base.Resolve();
        }
    }
}
