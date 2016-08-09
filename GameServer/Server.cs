using System;
using System.Collections.Generic;
using Game;
using GameBase.Game;

namespace GameServer
{
    public class Server : IServer
    {
        private readonly IEnumerable<IGameHeader> _gameTypeHeaders;

        public Server(IEnumerable<IGameHeader> gameTypeHeaders)
        {
            _gameTypeHeaders = gameTypeHeaders;
        }

        public void LogInPlayer(string name, string password)
        {
            throw new NotImplementedException();
        }

        public void LogOutPlayer(string name)
        {
            throw new NotImplementedException();
        }

        public void RegisterPlayer(string name, string password)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IGameHeader> GetGameHeaders()
        {
            return _gameTypeHeaders;
        }

        public IGame CreateGame(string gameName)
        {
            throw new NotImplementedException();
        }

        public IGame JoinGame(string gameId)
        {
            throw new NotImplementedException();
        }

        public void JoinGame(string playerName, string gameId)
        {
            throw new NotImplementedException();
        }

        public void WaitForOtherPlayer()
        {
            throw new NotImplementedException();
        }

        public void StartTheGame(string playerName, string gameId)
        {
            throw new NotImplementedException();
        }

        public void ValidateMove(string gameId, string playerName, IMoveData moveData)
        {
            throw new NotImplementedException();
        }

        public void MakeMove(string gameId, string playerName, IMoveData moveData)
        {
            throw new NotImplementedException();
        }
    }
}