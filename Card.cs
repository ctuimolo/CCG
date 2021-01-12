using System;
using System.Collections.Generic;
using System.Text;

namespace MGCCG.CCG
{
    public enum CardClass
    {
        Combat,
        Curse,
    }

    public abstract class Card
    {
        public string Name          { get; protected set; }
        public string EffectText    { get; protected set; }
        public string FlavorText    { get; protected set; }
        public CardClass Type    { get; protected set; }
        public int BaseCost { get; protected set; }
        public int Cost     { get; protected set; }

        public virtual void OnDraw() { }
        public virtual void OnPlay() { }
        public virtual void Resolve() { }
        public virtual void Discard() { }
    }
}
