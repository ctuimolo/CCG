using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGCCG.CCG
{
    public class Owner : IDamageable
    {
        public int  HP      { get; protected set; }
        public Hand Hand    { get; protected set; }
        public Deck Deck    { get; protected set; }

        public Owner(int initHP)
        {
            HP = initHP;

            Hand = new Hand();
            Deck = new Deck();
        }

        public void ReceiveAttack(CombatCard other)
        {
        }
    }
}
