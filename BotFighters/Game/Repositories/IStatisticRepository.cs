using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Repositories
{
    public interface IStatisticRepository
    {
        void UpdateStatistic(IPlayer player, IGameResult result);
    }
}
