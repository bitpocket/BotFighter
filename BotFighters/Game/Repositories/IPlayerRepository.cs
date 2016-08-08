using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Repositories
{
    public interface IPlayerRepository
    {
        void RegisterUser(string name, string password);
        IPlayer GetPlayer(string name, string password);
    }
}
