using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MGCCG.PlayerController;

namespace MGCCG.CCG
{
    class GameMaster
    {
        public Owner Player     { get; protected set; }
        public Dictionary<string, Owner> Enemies { get; protected set; }

        public GameMaster()
        {
            Enemies = new Dictionary<string, Owner>();
        }

        public void InitPlayer(Player player)
        {
            Player = new Owner(player.BaseHP);
        }
    }
}
