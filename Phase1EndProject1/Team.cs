using System;
using System.Collections.Generic;

namespace Phase1EndProject1
{
    internal interface Team
    {
            void AddPlayer(Player player);
            void RemovePlayer(int playerId);
            Player GetPlayerById(int playerId);
            List<Player> GetPlayersByName(string playerName);
            List<Player> GetAllPlayers();
        
    }
}
