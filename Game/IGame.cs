using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public interface IGame
    {
        int Id { get; set; }
        int MaxPlayer { get; set; }
        void ValidateMove(params object[] moveData);
        void MakeMove(params object[] moveData);
        IGameState GetGameState();
        bool CalculateEndCondition();
        IPlayer GetWinner();
    }
}
