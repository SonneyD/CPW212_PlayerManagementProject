using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDatabaseModule.DatebaseUtility
{
    public static class DB_PlayerQueries
    {
        public static List<Player> LoadAllPlayers()
        {
            PlayerDatabaseEntities context = new PlayerDatabaseEntities();

            List<Player> pList = context.Players.ToList();

            return pList;
        }
    }
}
